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
            if (Directory.Exists(sourceDir))
            {
                var dirs = Directory.GetDirectories(sourceDir);
                foreach (var dir in dirs)
                {
                    clbSourceFolder.Items.Add(dir);
                }
            }
        }
    }
}