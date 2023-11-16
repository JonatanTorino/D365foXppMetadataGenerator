namespace XmlMetadataGeneratorUI
{
    public static class MainFormMethods
    {
        public static string SelectPath(string initialDirectory)
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

        public static string GetFullPath(TreeNode node, TextBox txt)
        {
            // Obtiene la ruta completa del nodo, incluyendo los nodos padres
            List<string> pathParts = new List<string>();

            while (node != null)
            {
                pathParts.Insert(0, node.Text);
                node = node.Parent;
            }

            // Combina la ruta con la ruta del directorio raíz (sourceDir)
            string sourceDir = txt.Text;
            sourceDir = Directory.GetParent(sourceDir).FullName;
            pathParts.Insert(0, sourceDir);

            return Path.Combine(pathParts.ToArray());
        }

        public static void PopulateTreeViewRecursively(TreeNode parentNode, string parentPath, string[] folderNamesToSearch, string[] folderNamesToRemove)
        {
            // Itera a través de los subdirectorios en la ruta dada
            foreach (string subDir in Directory.GetDirectories(parentPath))
            {
                string subDirName = Path.GetFileName(subDir);

                // Verifica si el subdirectorio contiene al menos una de las carpetas buscadas
                if (folderNamesToSearch.Any(name => Directory.GetDirectories(subDir, name, SearchOption.AllDirectories).Any()))
                {
                    // Verifica si el subdirectorio está en la lista de carpetas para omitir
                    if (folderNamesToRemove.Contains(subDirName))
                    {
                        // Omitir este subdirectorio y no agregarlo al TreeView
                        continue;
                    }

                    // Agrega el subdirectorio como un nodo hijo del nodo padre
                    TreeNode node = new TreeNode(subDirName);
                    parentNode.Nodes.Add(node);

                    // Llama a PopulateTreeViewRecursively para seguir buscando en este subdirectorio
                    PopulateTreeViewRecursively(node, subDir, folderNamesToSearch, folderNamesToRemove);
                }
            }
        }

        public static void SetNodeCheckedState(TreeNodeCollection nodes, bool checkedState)
        {
            foreach (TreeNode node in nodes)
            {
                // Establece el estado de selección del nodo
                node.Checked = checkedState;

                // Llama de forma recursiva para los nodos secundarios
                SetNodeCheckedState(node.Nodes, checkedState);
            }
        }

        public static void CheckChildNodes(TreeNode node, bool isChecked)
        {
            foreach (TreeNode child in node.Nodes)
            {
                child.Checked = isChecked;
                CheckChildNodes(child, isChecked);
            }
        }

        public static List<TreeNode> GetSelectedNodes(TreeNodeCollection nodes)
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

        public static void enableGenerateButton(TextBox txt1, TextBox txt2, Button btn)
        {
            if (txt1.Text != "" && txt2.Text != "")
            {
                btn.Enabled = true;
            }
        }
    }
}
