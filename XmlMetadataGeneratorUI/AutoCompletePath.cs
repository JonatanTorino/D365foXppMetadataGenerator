using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

public class AutoCompletePath
{
    private TextBox textBox;
    private ListBox listBoxSuggestions;

    public AutoCompletePath(TextBox textBox, ListBox listBoxSuggestions)
    {
        this.textBox = textBox;
        this.listBoxSuggestions = listBoxSuggestions;

        this.listBoxSuggestions.Visible = false; // Inicialmente, el ListBox de sugerencias está oculto
        this.textBox.TextChanged += TextBox_TextChanged;
    }

    public void ShowSuggestions(string text)
    {
        string sourceDir = text;

        // Filtrar las sugerencias de carpetas aquí y agregarlas al ListBox
        string[] dirToRemove = { "bin", "Descriptor", "Reports", "Resources", "XppMetadata", "XppSource" };

        listBoxSuggestions.Items.Clear();

        if (Directory.Exists(sourceDir))
        {
            var directories = Directory.GetDirectories(sourceDir);
            var dirs = directories.Where(x => !dirToRemove.Any(y => x.Contains(y)));
            listBoxSuggestions.Items.AddRange(dirs.ToArray());

            if (listBoxSuggestions.Items.Count > 0)
            {
                listBoxSuggestions.Visible = true; // Mostrar el ListBox si hay sugerencias
            }
        }
        else
        {
            listBoxSuggestions.Visible = false; // Ocultar el ListBox si no hay sugerencias
        }
    }

    private void TextBox_TextChanged(object sender, EventArgs e)
    {
        ShowSuggestions(textBox.Text);
    }
}