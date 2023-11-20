namespace XmlMetadataGeneratorUI
{
    public partial class MainForm : Form
    {
        private bool todosMarcados = false;
        private AutoCompletePath autoComplete;
        private LastValuesManager lastValuesManager;
        private LastValues lastValues;
        delegate void ModeloTerminado();
        ModeloTerminado modeloTerminado;
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
            string sourceDir = cmbSourceFolder.Text;

            // Limpia los nodos existentes en el TreeView
            tvFolders.Nodes.Clear();

            // Verifica si el directorio de origen existe
            if (Directory.Exists(sourceDir))
            {
                TreeNode rootNode = new TreeNode(Path.GetFileName(sourceDir));
                tvFolders.Nodes.Add(rootNode);

                // Define los nombres de carpetas a buscar
                string[] folderNamesToSearch = { "AxClass", "AxTable", "AxForm", "AxDataEntityView" };

                // Define los nombres de carpetas a omitir
                string[] folderNamesToRemove = { "bin", "Descriptor", "Reports", "Resources", "XppMetadata", "XppSource" };

                // Llena el TreeView recursivamente
                MainFormMethods.PopulateTreeViewRecursively(rootNode, sourceDir, folderNamesToSearch, folderNamesToRemove);
            }
        }

        private void btnGenerateXpp_Click(object sender, EventArgs e)
        {
            progressBarFiles.Visible = true;
            progressBarFolders.Visible = true;
            progressBarModelos.Visible = true;
            progressBarModelos.Value = 0;
            progressBarFiles.Value = 0;
            progressBarFolders.Value = 0;

            // Obtén los nodos seleccionados en el TreeView
            var selectedNodes = MainFormMethods.GetSelectedNodes(tvFolders.Nodes);

            if (selectedNodes.Count > 0)
            {
                progressBarModelos.Maximum = selectedNodes.Count;
                lbTotalModel.Text = progressBarModelos.Maximum.ToString();
                lbTotalFolder.Text = "5";
                foreach (TreeNode selectedNode in selectedNodes)
                {
                    string dir = MainFormMethods.GetFullPath(selectedNode, cmbSourceFolder.Text);

                    XppGenerator xppGenerator = new XppGenerator(cmbDestinationFolder.Text);
                    progressBarFolders.Value = 0;
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
                MessageBox.Show("Debe seleccionar al menos una carpeta en el TreeView.");
            }
        }
        private void tvFolders_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode expandingNode = e.Node;

            // Evita recargar nodos ya cargados
            if (expandingNode.Nodes.Count == 1 && expandingNode.Nodes[0].Text == "...")
            {
                expandingNode.Nodes.Clear();

                // Obtiene la ruta completa del nodo expandido
                string fullPath = MainFormMethods.GetFullPath(expandingNode, cmbSourceFolder.Text);

                // Define los nombres de carpetas a buscar
                string[] folderNamesToSearch = { "AxClass", "AxTable", "AxForm", "AxDataEntityView" };

                // Define los nombres de carpetas a omitir
                string[] folderNamesToRemove = { "bin", "Descriptor", "Reports", "Resources", "XppMetadata", "XppSource" };

                // Llena el TreeView con las carpetas correctas
                MainFormMethods.PopulateTreeViewRecursively(expandingNode, fullPath, folderNamesToSearch, folderNamesToRemove);
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

        private void tvFolders_AfterCheck(object sender, TreeViewEventArgs e)
        {
            // Este evento se dispara cuando se marca o desmarca un nodo
            // Asegurémonos de que los nodos hijos se marquen o desmarquen en consecuencia
            MainFormMethods.CheckChildNodes(e.Node, e.Node.Checked);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool selectAll = checkBox1.Checked;

            // Recorre todos los nodos del TreeView y establece su estado de selección
            MainFormMethods.SetNodeCheckedState(tvFolders.Nodes, selectAll);
        }

    }
}