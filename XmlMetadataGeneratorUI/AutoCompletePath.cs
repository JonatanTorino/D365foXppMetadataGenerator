using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

public class AutoCompletePath
{
    private TextBox textBox;

    public AutoCompletePath(TextBox textBox)
    {
        this.textBox = textBox;
        ConfigureAutoComplete();
    }

    private void ConfigureAutoComplete()
    {
        // Configurar el TextBox para usar la funcionalidad de autocompletar del sistema operativo
        textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        textBox.AutoCompleteSource = AutoCompleteSource.FileSystem;
    }
}