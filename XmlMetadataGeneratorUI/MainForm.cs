namespace XmlMetadataGeneratorUI
{
    public partial class MainForm : Form
    {
        delegate void ModeloTerminado();
        ModeloTerminado modeloTerminado;
        public MainForm()
        {
            InitializeComponent();
            btnGenerateXpp.Enabled = false;
            modeloTerminado += avanzarProgressBarModelo;
            progressBarFiles.Visible = false;
            progressBarFolders.Visible = false;
            progressBarModelos.Visible = false;
        }
        private void avanzarProgressBarModelo()
        {
            progressBarModelos.Value += 1;
            lbModelProgress.Text = progressBarModelos.Value.ToString();
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
            progressBarFiles.Visible = true;
            progressBarFolders.Visible = true;
            progressBarModelos.Visible = true;
            progressBarModelos.Value = 0;
            progressBarFiles.Value = 0;
            progressBarFolders.Value = 0;
            if (foldersSelected.Count > 0)
            {
                progressBarModelos.Maximum = foldersSelected.Count;
                lbTotalModel.Text = progressBarModelos.Maximum.ToString();
                lbTotalFolder.Text = "5";
                foreach (var dir in foldersSelected.Cast<string>())
                {
                    progressBarFolders.Value = 0;
                    XppGenerator xppGenerator = new XppGenerator(txtDestinationFolder.Text);
                    xppGenerator.SetXppModelDirectory(dir);

                    xppGenerator.archivoGenerado += avanzarProgressBarArchivo;

                    AxClassReader axClassReader = new AxClassReader();
                    progressBarFiles.Maximum = axClassReader.GetFilesNumber(dir);
                    xppGenerator.ProcessAxFiles(dir, axClassReader);
                    AvanzarProgressBarCarpetas();

                    AxTableReader axTableReader = new AxTableReader();
                    progressBarFiles.Maximum = progressBarFiles.Maximum + axTableReader.GetFilesNumber(dir);
                    xppGenerator.ProcessAxFiles(dir, axTableReader);
                    AvanzarProgressBarCarpetas();

                    AxMapReader axMapReader = new AxMapReader();
                    progressBarFiles.Maximum = progressBarFiles.Maximum + axMapReader.GetFilesNumber(dir);
                    xppGenerator.ProcessAxFiles(dir, axMapReader);
                    AvanzarProgressBarCarpetas();

                    AxFormReader axFormReader = new AxFormReader();
                    progressBarFiles.Maximum = progressBarFiles.Maximum + axFormReader.GetFilesNumber(dir);
                    xppGenerator.ProcessAxFiles(dir, axFormReader);
                    AvanzarProgressBarCarpetas();

                    AxEntityReader axEntityReader = new AxEntityReader();
                    progressBarFiles.Maximum = progressBarFiles.Maximum + axEntityReader.GetFilesNumber(dir);
                    xppGenerator.ProcessAxFiles(dir, axEntityReader);
                    AvanzarProgressBarCarpetas();

                    lbTotalFile.Text = progressBarFiles.Maximum.ToString();

                    modeloTerminado();
                }
                MessageBox.Show("La cantidad de archivos generados son: " + progressBarFiles.Value);
            }
            else
            {
                MessageBox.Show("tiene que seleccionar una opcion");
            }
        }

        private void AvanzarProgressBarCarpetas()
        {
            progressBarFolders.Value += 1;
            lbFolderProgress.Text = progressBarFolders.Value.ToString();
        }

        private void avanzarProgressBarArchivo()
        {
            progressBarFiles.Value += 1;
            lbFileProgress.Text = progressBarFiles.Value.ToString();
        }

        private bool todosMarcados = false;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clbSourceFolder.Items.Count; i++)
            {
                clbSourceFolder.SetItemChecked(i, !todosMarcados);
            }
            todosMarcados = !todosMarcados;

        }

        private void clbSourceFolder_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}