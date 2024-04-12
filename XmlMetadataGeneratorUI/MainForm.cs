using System.Linq;
using System.Xml.Linq;

namespace XmlMetadataGeneratorUI
{
    public partial class MainForm : Form
    {
        private bool todosMarcados = false;
        private AutoCompletePath autoCompleteSourceFolder1;
        private AutoCompletePath autoCompleteDestinationFolder1;
        private LastValuesManager lastValuesManager;
        private LastValues lastValues;
        delegate void ModeloTerminado();
        ModeloTerminado modeloTerminado;
        public MainForm()
        {
            InitializeComponent();
            btnGenerateXpp.Enabled = false;

            autoCompleteSourceFolder1 = new AutoCompletePath(txtSourceFolder1);
            autoCompleteDestinationFolder1 = new AutoCompletePath(txtDestinationFolder1);

            lastValuesManager = new LastValuesManager();
            lastValues = lastValuesManager.LoadLastValues();


            txtSourceFolder1.Text = lastValues.SourceFolder;
            txtDestinationFolder1.Text = lastValues.DestinationFolder;

            txtSourceFolder1.TextChanged += txtSourceFolder_TextChanged;

            txtSourceFolder1.TextChanged += TxtSourceFolder_TextChanged;
            txtDestinationFolder1.TextChanged += TxtDestinationFolder_TextChanged;

            modeloTerminado += avanzarProgressBarModelo;
            grpFile.Visible = false;
            grpModel.Visible = false;
            grpFolder.Visible = false;
            gbxModel.Visible = false;
            gbxFolder.Visible = false;
            gbxFile.Visible = false;

            if (IsValidFolderPath(txtSourceFolder1.Text) && IsValidFolderPath(txtDestinationFolder1.Text))
            {
                btnGenerateXpp.Enabled = true;
                this.refreshTree(txtSourceFolder1.Text);
            }

        }
        private void avanzarProgressBarModelo()
        {
            if (progressBarModelos.Value < progressBarModelos.Maximum)
            {
                progressBarModelos.Value += 1;
                lbModelProgress.Text = progressBarModelos.Value.ToString();
            }
        }

        private void TxtSourceFolder_TextChanged(object sender, EventArgs e)
        {
            lastValues.SourceFolder = txtSourceFolder1.Text;
            lastValuesManager.SaveLastValues(lastValues);

            // Verifica si ambos cuadros de texto tienen rutas válidas
            if (IsValidFolderPath(txtSourceFolder1.Text) && IsValidFolderPath(txtDestinationFolder1.Text))
            {
                // Activa el botón btnGenerateXpp
                btnGenerateXpp.Enabled = true;
            }
            else
            {
                // Desactiva el botón btnGenerateXpp
                btnGenerateXpp.Enabled = false;
            }
        }

        private void TxtDestinationFolder_TextChanged(object sender, EventArgs e)
        {
            lastValues.DestinationFolder = txtDestinationFolder1.Text;
            lastValuesManager.SaveLastValues(lastValues);

            // Verifica si ambos cuadros de texto tienen rutas válidas
            if (IsValidFolderPath(txtSourceFolder1.Text) && IsValidFolderPath(txtDestinationFolder1.Text))
            {
                // Activa el botón btnGenerateXpp
                btnGenerateXpp.Enabled = true;
            }
            else
            {
                // Desactiva el botón btnGenerateXpp
                btnGenerateXpp.Enabled = false;
            }
        }

        private bool IsValidFolderPath(string path)
        {
            // Puedes agregar lógica adicional aquí según tus requisitos
            return !string.IsNullOrWhiteSpace(path) && Directory.Exists(path);
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
            txtSourceFolder1.Text = SelectPath(initialDir);
        }

        private void btnDestinationFolder_Click(object sender, EventArgs e)
        {
            txtDestinationFolder1.Text = SelectPath(string.Empty);
        }

        private void txtSourceFolder_TextChanged(object sender, EventArgs e)
        {
            string sourceDir = txtSourceFolder1.Text;

            this.refreshTree(sourceDir);
        }

        private void refreshTree(string sourceDir)
        {
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

                grpFile.Visible = false;
                grpModel.Visible = false;
                grpFolder.Visible = false;
                gbxModel.Visible = false;
                gbxFolder.Visible = false;
                gbxFile.Visible = false;
            }

        }

        private void btnGenerateXpp_Click(object sender, EventArgs e)
        {
            // Obtén los nodos seleccionados en el TreeView
            //var selectedNodes = MainFormMethods.GetSelectedNodes(tvFolders.Nodes);
            List<TreeNode> selectedNodes = GetSelectedNodes(tvFolders.Nodes);

            if (selectedNodes.Count > 0)
            {
                List<TreeNode> updatedNodes = new List<TreeNode>();

                grpFile.Visible = true;
                grpModel.Visible = true;
                grpFolder.Visible = true;
                gbxModel.Visible = true;
                gbxFolder.Visible = true;
                gbxFile.Visible = true;

                progressBarFiles.Value = 0;
                progressBarFiles.Maximum = 0;

                progressBarModelos.Value = 0;
                progressBarModelos.Maximum = selectedNodes.GroupBy(p => p.Text).Select(grp => grp.FirstOrDefault()).Count();
                lbTotalModel.Text = progressBarModelos.Maximum.ToString();

                progressBarFolders.Value = 0;
                progressBarFolders.Maximum = (5 * progressBarModelos.Maximum);
                lbTotalFolder.Text = progressBarFolders.Maximum.ToString(); // "5";

                int cant = 0;

                foreach (TreeNode selectedNode in selectedNodes)
                {
                    // si hay nodos repetidos se ignoran
                    if (updatedNodes.IndexOf(selectedNode) >= 0)
                    {
                        continue;
                    }
                    updatedNodes.Add(selectedNode);

                    string dir = MainFormMethods.GetFullPath(selectedNode, txtSourceFolder1.Text);

                    XppGenerator xppGenerator = new XppGenerator(txtDestinationFolder1.Text);
                    
                    xppGenerator.SetXppModelDirectory(dir);

                    xppGenerator.archivoGenerado += AvanzarProgressBarArchivo;

                    AxClassReader axClassReader = new AxClassReader();
                    cant = axClassReader.GetFilesNumber(dir);
                    progressBarFiles.Maximum += cant;
                    xppGenerator.ProcessAxFiles(dir, axClassReader);
                    AvanzarProgressBarCarpetas();

                    AxTableReader axTableReader = new AxTableReader();
                    cant = axTableReader.GetFilesNumber(dir);
                    progressBarFiles.Maximum += cant;
                    xppGenerator.ProcessAxFiles(dir, axTableReader);
                    AvanzarProgressBarCarpetas();

                    AxMapReader axMapReader = new AxMapReader();
                    cant = axMapReader.GetFilesNumber(dir);
                    progressBarFiles.Maximum += cant;
                    xppGenerator.ProcessAxFiles(dir, axMapReader);
                    AvanzarProgressBarCarpetas();

                    AxFormReader axFormReader = new AxFormReader();
                    cant = axFormReader.GetFilesNumber(dir);
                    progressBarFiles.Maximum += cant;
                    xppGenerator.ProcessAxFiles(dir, axFormReader);
                    AvanzarProgressBarCarpetas();

                    AxEntityReader axEntityReader = new AxEntityReader();
                    cant = axEntityReader.GetFilesNumber(dir);
                    progressBarFiles.Maximum += cant;
                    xppGenerator.ProcessAxFiles(dir, axEntityReader);
                    AvanzarProgressBarCarpetas();

                    lbTotalFile.Text = progressBarFiles.Maximum.ToString();

                    modeloTerminado();
                }
                MessageBox.Show("La cantidad de archivos generados son: " + progressBarFiles.Value);

                grpFile.Visible = false;
                grpModel.Visible = false;
                grpFolder.Visible = false;
                gbxModel.Visible = false;
                gbxFolder.Visible = false;
                gbxFile.Visible = false;

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
                string fullPath = MainFormMethods.GetFullPath(expandingNode, txtSourceFolder1.Text);

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
            if (progressBarFolders.Value < progressBarFolders.Maximum)
            {
                progressBarFolders.Value += 1;
                lbFolderProgress.Text = progressBarFolders.Value.ToString();
            }
        }

        private void AvanzarProgressBarArchivo()
        {
            // Incrementa el valor máximo del ProgressBar según sea necesario
            //progressBarFiles.Maximum += 1;

            // Asegúrate de que el nuevo valor esté dentro del rango permitido
            if (progressBarFiles.Value < progressBarFiles.Maximum)
            {
                progressBarFiles.Value += 1;
                lbFileProgress.Text = progressBarFiles.Value.ToString();
            }
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

        public static List<TreeNode> GetSelectedNodes(TreeNodeCollection nodes)
        {
            List<TreeNode> selectedNodes = new List<TreeNode>();

            foreach (TreeNode node in nodes)
            {
                if (node.Checked) // Cambiado de IsSelected a Checked
                {
                    // Si el nodo padre está seleccionado, agregar también sus hijos
                    if (node.Nodes.Count > 0 && node.Nodes.Cast<TreeNode>().All(child => child.Checked))
                    {
                        selectedNodes.AddRange(node.Nodes.Cast<TreeNode>());
                    }
                    else
                    {
                        selectedNodes.Add(node);
                    }
                }

                selectedNodes.AddRange(GetSelectedNodes(node.Nodes));
            }

            return selectedNodes;
        }
    }
}