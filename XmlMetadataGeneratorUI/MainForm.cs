namespace XmlMetadataGeneratorUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnGenerateXpp.Enabled = false;
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

            int srcFolders = 0;

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
                progressBar1.Maximum = clbSourceFolder.Items.Count;
                lbTotalFiles.Text = clbSourceFolder.Items.Count.ToString();
                progressBar1.Value = 0;
                foreach (var dir in clbSourceFolder.Items)
                {
                    progressBar1.Value = progressBar1.Value + 1;
                    lbFileProgress.Text = progressBar1.Value.ToString();
                }
            }
        }

        private void btnGenerateXpp_Click(object sender, EventArgs e)
        {
            var foldersSelected = clbSourceFolder.CheckedItems;
            progressBar1.Value = 0;
            if (foldersSelected.Count > 0)
            {
                foreach (var dir in foldersSelected.Cast<string>())
                {
                    XppGenerator xppGenerator = new XppGenerator(txtDestinationFolder.Text);
                    xppGenerator.SetXppModelDirectory(dir);

                    AxClassReader axClassReader = new AxClassReader();
                    progressBar1.Value = progressBar1.Value + xppGenerator.ProcessAxFiles(dir, axClassReader);
                    lbFileProgress.Text = progressBar1.Value.ToString();

                    AxTableReader axTableReader = new AxTableReader();
                    progressBar1.Value = progressBar1.Value + xppGenerator.ProcessAxFiles(dir, axTableReader);
                    lbFileProgress.Text = progressBar1.Value.ToString();

                    AxMapReader axMapReader = new AxMapReader();
                    progressBar1.Value = progressBar1.Value + xppGenerator.ProcessAxFiles(dir, axMapReader);
                    lbFileProgress.Text = progressBar1.Value.ToString();

                    AxFormReader axFormReader = new AxFormReader();
                    progressBar1.Value = progressBar1.Value + xppGenerator.ProcessAxFiles(dir, axFormReader);
                    lbFileProgress.Text = progressBar1.Value.ToString();

                    AxEntityReader axEntityReader = new AxEntityReader();
                    progressBar1.Value = progressBar1.Value + xppGenerator.ProcessAxFiles(dir, axEntityReader);
                    lbFileProgress.Text = progressBar1.Value.ToString();
                }
                MessageBox.Show("La cantidad de archivos generados son: " + lbTotalFiles.Text);
            }
            else
            {
                MessageBox.Show("tiene que seleccionar una opcion");
            }
        }

        private bool todosMarcados = false;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = clbSourceFolder.Items.Count;
            for (int i = 0; i < clbSourceFolder.Items.Count; i++)
            {
                clbSourceFolder.SetItemChecked(i, !todosMarcados);
                progressBar1.Value = progressBar1.Value + 1;
                lbFileProgress.Text = progressBar1.Value.ToString();
            }
            lbTotalFiles.Text = clbSourceFolder.Items.Count.ToString();
            todosMarcados = !todosMarcados;

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void clbSourceFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            int amount = 0;
            var foldersSelected = clbSourceFolder.CheckedItems;
            lbTotalFiles.Text = "0";
            foreach (var dir in foldersSelected.Cast<string>())
            {
                XppGenerator xppGenerator = new XppGenerator(txtDestinationFolder.Text);
                xppGenerator.SetXppModelDirectory(dir);

                AxClassReader axClassReader = new AxClassReader();
                amount = amount + xppGenerator.GetAxFiles(dir, axClassReader);

                AxTableReader axTableReader = new AxTableReader();
                amount = amount + xppGenerator.GetAxFiles(dir, axTableReader);

                AxMapReader axMapReader = new AxMapReader();
                amount = amount + xppGenerator.GetAxFiles(dir, axMapReader);

                AxFormReader axFormReader = new AxFormReader();
                amount = amount + xppGenerator.GetAxFiles(dir, axFormReader);

                AxEntityReader axEntityReader = new AxEntityReader();
                amount = amount + xppGenerator.GetAxFiles(dir, axEntityReader);
            }
            lbTotalFiles.Text = amount.ToString();
            lbFileProgress.Text = "0";
            progressBar1.Maximum = int.Parse(lbTotalFiles.Text);
            progressBar1.Value = 0;

        }
    }
}