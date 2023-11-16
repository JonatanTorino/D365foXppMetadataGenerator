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
            autoComplete = new AutoCompletePath(cmbSourceFolder);
            autoComplete = new AutoCompletePath(cmbDestinationFolder);

            lastValuesManager = new LastValuesManager();
            lastValues = lastValuesManager.LoadLastValues();

            cmbSourceFolder.Text = lastValues.SourceFolder;
            cmbDestinationFolder.Text = lastValues.DestinationFolder;

            cmbSourceFolder.TextChanged += cmbSourceFolder_TextChanged;
            cmbDestinationFolder.TextChanged += CmbDestinationFolder_TextChanged;
        }

        private void CmbSourceFolder_TextChanged(object sender, EventArgs e)
        {
            lastValues.SourceFolder = cmbSourceFolder.Text;
            lastValuesManager.SaveLastValues(lastValues);
        }

        private void CmbDestinationFolder_TextChanged(object sender, EventArgs e)
        {
            lastValues.DestinationFolder = cmbDestinationFolder.Text;
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
            cmbSourceFolder.Text = SelectPath(initialDir);
        }

        private void btnDestinationFolder_Click(object sender, EventArgs e)
        {
            cmbDestinationFolder.Text = SelectPath(string.Empty);
            btnGenerateXpp.Enabled = true;
        }

        private void cmbSourceFolder_TextChanged(object sender, EventArgs e)
        {
            clbSourceFolder.Items.Clear();

            string sourceDir = cmbSourceFolder.Text;

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
                    XppGenerator xppGenerator = new XppGenerator(cmbDestinationFolder.Text);
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
    }
}