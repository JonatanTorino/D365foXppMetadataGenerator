namespace XmlMetadataGeneratorUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
            foreach (var dir in foldersSelected.Cast<string>())
            {
                XppGenerator xppGenerator = new XppGenerator(txtDestinationFolder.Text);
                xppGenerator.SetXppModelDirectory(dir);

                AxClassReader axClassReader = new AxClassReader();
                xppGenerator.ProcessAxFiles(dir, axClassReader);

                AxTableReader axTableReader = new AxTableReader();
                xppGenerator.ProcessAxFiles(dir, axTableReader);

                AxMapReader axMapReader = new AxMapReader();
                xppGenerator.ProcessAxFiles(dir, axMapReader);

                AxFormReader axFormReader = new AxFormReader();
                xppGenerator.ProcessAxFiles(dir, axFormReader);
            }
        }
    }
}