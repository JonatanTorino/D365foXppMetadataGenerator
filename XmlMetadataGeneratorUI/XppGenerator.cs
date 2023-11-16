namespace XmlMetadataGeneratorUI
{
    public class XppGenerator
    {
        private const string XPPSOURCE = "XppSource";
        private readonly string xppSourceFolder;
        private string xppSourceModelFolder;
        public delegate void ArchivoGenerado();
        public ArchivoGenerado archivoGenerado;

        public XppGenerator(string destinationFolder)
        {
            if (string.IsNullOrEmpty(destinationFolder))
            {
                throw new ArgumentNullException(nameof(destinationFolder));
            }
            this.xppSourceFolder = Path.Combine(destinationFolder, XPPSOURCE);
        }

        public int ProcessAxFiles(string dir, AxBaseReader axReader)
        {
            string axFolder = Path.Combine(dir, axReader.AxFolderName);
            if (!Directory.Exists(axFolder))
            {
                return 0;
            }
            string[] axFiles = Directory.GetFiles(axFolder);
            foreach (var axFile in axFiles)
            {
                var axContent = axReader.GenerateXppFileContent(axFile);
                if (axContent != null)
                {
                    SaveXppFile(xppSourceModelFolder, axFile, axContent);
                    archivoGenerado();
                }
            }
            return axFiles.Length;
        }
        public int GetAxFiles(string dir, AxBaseReader axReader)
        {
            string axFolder = Path.Combine(dir, axReader.AxFolderName);
            if (!Directory.Exists(axFolder))
            {
                return 0;
            }
            string[] axFiles = Directory.GetFiles(axFolder);
            return axFiles.Length;
        }


        public string SetXppModelDirectory(string dir)
        {
            var dirName = new DirectoryInfo(dir).Name;
            xppSourceModelFolder = Path.Combine(xppSourceFolder, dirName);
            if (!Directory.Exists(xppSourceModelFolder))
            {
                Directory.CreateDirectory(xppSourceModelFolder);
            }

            return xppSourceModelFolder;
        }

        private static void SaveXppFile(string destinationFolder, string axFile, string axContent)
        {
            const string xppExt = ".xpp";
            var axFileXPP = Path.GetFileNameWithoutExtension(axFile);
            var axFolder = new FileInfo(axFile).Directory.Name;
            axFileXPP = Path.ChangeExtension(axFileXPP, xppExt);
            axFileXPP = $"{axFolder}_{axFileXPP}";
            var axDestinationFileName = Path.Combine(destinationFolder, axFileXPP);
            if (File.Exists(axDestinationFileName)) { File.Delete(axDestinationFileName); }
            File.WriteAllText(axDestinationFileName, axContent);
        }
    }
}