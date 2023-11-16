using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

public class AutoCompletePath
{
    private ComboBox comboBox;
    private string currentText = string.Empty;

    public AutoCompletePath(ComboBox comboBox)
    {
        this.comboBox = comboBox;
        comboBox.DropDown += ComboBox_DropDown;
        comboBox.TextChanged += ComboBox_TextChanged;
        comboBox.Leave += ComboBox_Leave;
    }

    private void ComboBox_DropDown(object sender, EventArgs e)
    {
        // Cuando se despliegan las opciones, asegúrate de mostrar las sugerencias nuevamente.
        ShowSuggestions(currentText);
    }

    private void ComboBox_TextChanged(object sender, EventArgs e)
    {
        // Captura el texto actual en el ComboBox mientras el usuario escribe.
        currentText = comboBox.Text;
    }

    private void ComboBox_Leave(object sender, EventArgs e)
    {
        // Cuando el ComboBox pierde el foco, muestra las sugerencias nuevamente.
        ShowSuggestions(currentText);
    }

    public void ShowSuggestions(string text)
    {
        string sourceDir = text;

        // Filtrar las sugerencias de carpetas aquí
        string[] dirToRemove = { "bin", "Descriptor", "Reports", "Resources", "XppMetadata", "XppSource" };

        comboBox.Items.Clear();

        if (Directory.Exists(sourceDir))
        {
            var directories = Directory.GetDirectories(sourceDir);
            var dirs = directories.Where(x => !dirToRemove.Any(y => x.Contains(y)));
            comboBox.Items.AddRange(dirs.ToArray());
        }

        // Restaura el texto original después de actualizar las sugerencias.
        comboBox.Text = currentText;
        // Coloca el cursor al final del texto para que el usuario pueda seguir escribiendo.
        comboBox.Select(comboBox.Text.Length, 0);
    }
}