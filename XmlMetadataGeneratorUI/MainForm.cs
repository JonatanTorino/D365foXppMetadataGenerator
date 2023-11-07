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
            txtSourceFolder.Text = MainFormMethods.SelectPath(initialDir);
            MainFormMethods.enableGenerateButton(txtSourceFolder, txtDestinationFolder, btnGenerateXpp);
        }

        private void btnDestinationFolder_Click(object sender, EventArgs e)
        {
            txtDestinationFolder.Text = MainFormMethods.SelectPath(string.Empty);
            MainFormMethods.enableGenerateButton(txtSourceFolder, txtDestinationFolder, btnGenerateXpp);
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

                // Define los nombres de carpetas a omitir
                string[] folderNamesToRemove = { "bin", "Descriptor", "Reports", "Resources", "XppMetadata", "XppSource" };

                // Llena el TreeView recursivamente
                MainFormMethods.PopulateTreeViewRecursively(rootNode, sourceDir, folderNamesToSearch, folderNamesToRemove);
            }
        }

        private void btnGenerateXpp_Click(object sender, EventArgs e)
        {
            // Obtén los nodos seleccionados en el TreeView
            var selectedNodes = MainFormMethods.GetSelectedNodes(tvFolders.Nodes);

            if (selectedNodes.Count > 0)
            {
                foreach (TreeNode selectedNode in selectedNodes)
                {
                    string dir = MainFormMethods.GetFullPath(selectedNode, txtSourceFolder);

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

        private void tvFolders_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode expandingNode = e.Node;

            // Evita recargar nodos ya cargados
            if (expandingNode.Nodes.Count == 1 && expandingNode.Nodes[0].Text == "...")
            {
                expandingNode.Nodes.Clear();

                // Obtiene la ruta completa del nodo expandido
                string fullPath = MainFormMethods.GetFullPath(expandingNode, txtSourceFolder);

                // Define los nombres de carpetas a buscar
                string[] folderNamesToSearch = { "AxClass", "AxTable", "AxForm", "AxDataEntityView" };

                // Define los nombres de carpetas a omitir
                string[] folderNamesToRemove = { "bin", "Descriptor", "Reports", "Resources", "XppMetadata", "XppSource" };

                // Llena el TreeView con las carpetas correctas
                MainFormMethods.PopulateTreeViewRecursively(expandingNode, fullPath, folderNamesToSearch, folderNamesToRemove);
            }
        }

        private void tvFolders_AfterCheck(object sender, TreeViewEventArgs e)
        {
            // Este evento se dispara cuando se marca o desmarca un nodo
            // Asegurémonos de que los nodos hijos se marquen o desmarquen en consecuencia
            MainFormMethods.CheckChildNodes(e.Node, e.Node.Checked);
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            bool selectAll = checkBox1.Checked;

            // Recorre todos los nodos del TreeView y establece su estado de selección
            MainFormMethods.SetNodeCheckedState(tvFolders.Nodes, selectAll);
        }
    }
}