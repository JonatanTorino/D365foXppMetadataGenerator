namespace XmlMetadataGeneratorUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSourceFolder_Click(object sender, EventArgs e)
        {
            string initialDir = $@"{Environment.GetEnvironmentVariable("SERVICEDRIVE")}\AosService\PackagaLocalDirectory\";
            txtSourceFolder.Text = SelectPath(initialDir);
            enableGenerateButton();
        }

        private void btnDestinationFolder_Click(object sender, EventArgs e)
        {
            txtDestinationFolder.Text = SelectPath(string.Empty);
            enableGenerateButton();
        }

        private void txtSourceFolder_TextChanged(object sender, EventArgs e)
        {
            string sourceDir = txtSourceFolder.Text;

            // Limpia los nodos existentes en el TreeView
            tvFolders.Nodes.Clear();

            // Verifica si el directorio de origen existe
            if (Directory.Exists(sourceDir))
            {
                TreeNode rootNode = new TreeNode(Path.GetFileName(sourceDir));
                tvFolders.Nodes.Add(rootNode);

                // Define los nombres de carpetas a buscar
                string[] folderNamesToSearch = { "AxClass", "AxTable", "AxForm", "AxDataEntityView" };

                // Llena el TreeView recursivamente
                PopulateTreeViewRecursively(rootNode, sourceDir, folderNamesToSearch);
            }
        }

        private void btnGenerateXpp_Click(object sender, EventArgs e)
        {
            // Obtén los nodos seleccionados en el TreeView
            var selectedNodes = GetSelectedNodes(tvFolders.Nodes);

            if (selectedNodes.Count > 0)
            {
                foreach (TreeNode selectedNode in selectedNodes)
                {
                    string dir = GetFullPath(selectedNode);

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

                    AxEntityReader axEntityReader = new AxEntityReader();
                    xppGenerator.ProcessAxFiles(dir, axEntityReader);
                }
                MessageBox.Show("Los archivos fueron generados correctamente");
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos una carpeta en el TreeView.");
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            bool selectAll = checkBox1.Checked;

            // Recorre todos los nodos del TreeView y establece su estado de selección
            SetNodeCheckedState(tvFolders.Nodes, selectAll);
        }

        private void tvFolders_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode expandingNode = e.Node;

            // Evita recargar nodos ya cargados
            if (expandingNode.Nodes.Count == 1 && expandingNode.Nodes[0].Text == "...")
            {
                expandingNode.Nodes.Clear();

                // Obtiene la ruta completa del nodo expandido
                string fullPath = GetFullPath(expandingNode);

                // Define los nombres de carpetas a buscar
                string[] folderNamesToSearch = { "AxClass", "AxTable", "AxForm", "AxDataEntityView" };

                /// Define los nombres de carpetas a excluir
                string[] folderNamesToRemove = { "bin", "Descriptor", "Reports", "Resources", "XppMetadata", "XppSource" };
                /// Corregir descarga de XML

                // Llena el TreeView con las carpetas correctas
                PopulateTreeViewRecursively(expandingNode, fullPath, folderNamesToSearch);
            }
        }

        private void tvFolders_AfterCheck(object sender, TreeViewEventArgs e)
        {
            // Este evento se dispara cuando se marca o desmarca un nodo
            // Asegurémonos de que los nodos hijos se marquen o desmarquen en consecuencia
            CheckChildNodes(e.Node, e.Node.Checked);
        }

        private string GetFullPath(TreeNode node)
        {
            // Obtiene la ruta completa del nodo, incluyendo los nodos padres
            List<string> pathParts = new List<string>();

            while (node != null)
            {
                pathParts.Insert(0, node.Text);
                node = node.Parent;
            }

            // Combina la ruta con la ruta del directorio raíz (sourceDir)
            string sourceDir = txtSourceFolder.Text;
            pathParts.Insert(0, sourceDir);

            return Path.Combine(pathParts.ToArray());
        }

        private List<TreeNode> GetSelectedNodes(TreeNodeCollection nodes)
        {
            List<TreeNode> selectedNodes = new List<TreeNode>();

            foreach (TreeNode node in nodes)
            {
                if (node.Checked) // Cambiado de IsSelected a Checked
                {
                    selectedNodes.Add(node);

                    // Si el nodo padre está seleccionado, agregar también sus hijos
                    if (node.Nodes.Count > 0 && node.Nodes.Cast<TreeNode>().All(child => child.Checked))
                    {
                        selectedNodes.AddRange(node.Nodes.Cast<TreeNode>());
                    }
                }

                selectedNodes.AddRange(GetSelectedNodes(node.Nodes));
            }

            return selectedNodes;
        }

        private void SetNodeCheckedState(TreeNodeCollection nodes, bool checkedState)
        {
            foreach (TreeNode node in nodes)
            {
                // Establece el estado de selección del nodo
                node.Checked = checkedState;

                // Llama de forma recursiva para los nodos secundarios
                SetNodeCheckedState(node.Nodes, checkedState);
            }
        }

        private void PopulateTreeViewRecursively(TreeNode parentNode, string parentPath, string[] folderNamesToSearch)
        {
            // Itera a través de los subdirectorios en la ruta dada
            foreach (string subDir in Directory.GetDirectories(parentPath))
            {
                string subDirName = Path.GetFileName(subDir);

                // Comprueba si el subdirectorio contiene al menos una de las carpetas buscadas
                if (folderNamesToSearch.Any(name => Directory.GetDirectories(subDir, name, SearchOption.AllDirectories).Any()))
                {
                    // Agrega el subdirectorio como un nodo hijo del nodo padre
                    TreeNode node = new TreeNode(subDirName);
                    parentNode.Nodes.Add(node);

                    // Llama a PopulateTreeViewRecursively para seguir buscando en este subdirectorio
                    PopulateTreeViewRecursively(node, subDir, folderNamesToSearch);
                }
            }
        }

        private void CheckChildNodes(TreeNode node, bool isChecked)
        {
            foreach (TreeNode child in node.Nodes)
            {
                child.Checked = isChecked;
                CheckChildNodes(child, isChecked);
            }
        }

        private void enableGenerateButton()
        {
            if (txtSourceFolder.Text == "" || txtDestinationFolder.Text == "")
            {
                btnGenerateXpp.Enabled = false;
            }
            else
            {
                btnGenerateXpp.Enabled = true;
            }
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

    }

}