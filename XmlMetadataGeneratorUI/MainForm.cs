namespace XmlMetadataGeneratorUI
{
    public partial class MainForm : Form
    {
        private bool todosMarcados = false;
        private AutoCompletePath autoComplete;
        private LastValuesManager lastValuesManager;
        private LastValues lastValues;
        public MainForm()
        {
            InitializeComponent();
            btnGenerateXpp.Enabled = false;
            autoComplete = new AutoCompletePath(txtSourceFolder, listBoxSuggestions);

            lastValuesManager = new LastValuesManager();
            lastValues = lastValuesManager.LoadLastValues();

            txtSourceFolder.Text = lastValues.SourceFolder;
            txtDestinationFolder.Text = lastValues.DestinationFolder;

            txtSourceFolder.TextChanged += TxtSourceFolder_TextChanged;
            txtDestinationFolder.TextChanged += TxtDestinationFolder_TextChanged;

            listBoxSuggestions.MouseDoubleClick += ListBoxSuggestions_MouseDoubleClick;
        }

        private void TxtSourceFolder_TextChanged(object sender, EventArgs e)
        {
            lastValues.SourceFolder = txtSourceFolder.Text;
            lastValuesManager.SaveLastValues(lastValues);
        }

        private void TxtDestinationFolder_TextChanged(object sender, EventArgs e)
        {
            lastValues.DestinationFolder = txtDestinationFolder.Text;
            lastValuesManager.SaveLastValues(lastValues);
        }

        private string SelectPath(string initialDirectory)
        {
            string selectedPath = string.Empty;
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.InitialDirectory = initialDirectory;
                folderDialog.ShowNewFolderButton = false;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedPath = folderDialog.SelectedPath;
                }
            }
            return selectedPath;
        }

        private void btnSourceFolder_Click(object sender, EventArgs e)
        {
            string initialDir = $@"{Environment.GetEnvironmentVariable("SERVICEDRIVE")}\AosService\PackagaLocalDirectory\";
            txtSourceFolder.Text = SelectPath(initialDir);
        }

        private void btnDestinationFolder_Click(object sender, EventArgs e)
        {
            txtDestinationFolder.Text = SelectPath(string.Empty);
            btnGenerateXpp.Enabled = true;
        }

        private void txtSourceFolder_TextChanged(object sender, EventArgs e)
        {
            clbSourceFolder.Items.Clear();

            string sourceDir = txtSourceFolder.Text;

            //TODO Mover los valores de [dirToRemove] a un archivo de configuración (con opción de restaurar predeterminados)
            string[] dirToRemove = { "bin", "Descriptor", "Reports", "Resources", "XppMetadata", "XppSource" };

            if (Directory.Exists(sourceDir))
            {
                var directories = Directory.GetDirectories(sourceDir);
                var dirs = directories.Where(x => !dirToRemove.Any(y => x.Contains(y)));
                foreach (var dir in dirs)
                {
                    clbSourceFolder.Items.Add(dir);
                }
            }
        }

        private void btnGenerateXpp_Click(object sender, EventArgs e)
        {
            var foldersSelected = clbSourceFolder.CheckedItems;
            int axFilesAmount = 0;
            if (foldersSelected.Count > 0)
            {
                foreach (var dir in foldersSelected.Cast<string>())
                {
                    XppGenerator xppGenerator = new XppGenerator(txtDestinationFolder.Text);
                    xppGenerator.SetXppModelDirectory(dir);

                    AxClassReader axClassReader = new AxClassReader();
                    axFilesAmount = axFilesAmount + xppGenerator.ProcessAxFiles(dir, axClassReader);

                    AxTableReader axTableReader = new AxTableReader();
                    axFilesAmount = axFilesAmount + xppGenerator.ProcessAxFiles(dir, axTableReader);

                    AxMapReader axMapReader = new AxMapReader();
                    axFilesAmount = axFilesAmount + xppGenerator.ProcessAxFiles(dir, axMapReader);

                    AxFormReader axFormReader = new AxFormReader();
                    axFilesAmount = axFilesAmount + xppGenerator.ProcessAxFiles(dir, axFormReader);

                    AxEntityReader axEntityReader = new AxEntityReader();
                    axFilesAmount = axFilesAmount + xppGenerator.ProcessAxFiles(dir, axEntityReader);
                }
                MessageBox.Show("La cantidad de archivos generados es: " + axFilesAmount);
            }
            else
            {
                MessageBox.Show("tiene que seleccionar una opcion");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < clbSourceFolder.Items.Count; i++)
            {
                clbSourceFolder.SetItemChecked(i, !todosMarcados);
            }
            todosMarcados = !todosMarcados;
        }

        private void ListBoxSuggestions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxSuggestions.SelectedItem != null)
            {
                string selectedFolder = listBoxSuggestions.SelectedItem.ToString();
                string currentText = txtSourceFolder.Text;
                string newText;

                if (currentText.EndsWith("\\"))
                {
                    // Si ya hay una barra diagonal invertida al final, newte va a ser lo mismo que selectedFolder.
                    newText = selectedFolder + "\\";
                }
                else
                {
                    // Agrega una barra diagonal invertida al final.
                    newText = currentText + "\\" + selectedFolder + "\\";
                }

                txtSourceFolder.Text = newText;

                // Actualiza las sugerencias en el ListBoxSuggestions
                autoComplete.ShowSuggestions(newText);

                // Oculta el ListBoxSuggestions si no hay más sugerencias
                if (listBoxSuggestions.Items.Count == 0)
                {
                    listBoxSuggestions.Visible = false;
                }
            }
        }

    }
}