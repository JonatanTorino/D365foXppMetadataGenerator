using System.Text;
using System.Xml;

namespace XmlMetadataGeneratorUI
{
    public abstract class AxBaseReader
    {
        public string AxFolderName { get; init; }

        protected AxBaseReader(string axFolderName)
        {
            AxFolderName = axFolderName;
        }

        public string GenerateXppFileContent(string axFile)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(axFile);
            string sourceCodeDeclaration = ReadHeaderDeclaration(xmlDocument);
            if (string.IsNullOrEmpty(sourceCodeDeclaration))
            {
                return string.Empty;
            }
            string body = ReadBody(xmlDocument);

            string xppContent = MergeDeclarationAndBody(sourceCodeDeclaration, body);
            Console.WriteLine(xppContent);

            return xppContent;
        }

        protected abstract string ReadHeaderDeclaration(XmlDocument xmlDocument);

        protected abstract string ReadBody(XmlDocument xmlDocument);

        protected string GetMethodsSourceCode(XmlNodeList? xmlNodeMethodsList)
        {
            string body = string.Empty;
            if (xmlNodeMethodsList != null)
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (XmlNode xmlNode in xmlNodeMethodsList)
                {
                    stringBuilder.AppendLine(xmlNode.InnerText.TrimEnd());
                }
                body = stringBuilder.ToString();
            }

            return body;
        }

        private static string MergeDeclarationAndBody(string classDeclaration, string classBody)
        {
            string[] declarationLines = classDeclaration.Trim().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            string declarationBegin = string.Join(Environment.NewLine, declarationLines.Take(declarationLines.Length - 1));
            declarationBegin = declarationBegin.TrimEnd();
            string declarationEnd = declarationLines.Last();

            string body = classBody;
            int index = classBody.ToString().IndexOf(Environment.NewLine);
            if (index >= 0)
            {
                body = classBody.Remove(0, index + Environment.NewLine.Length);
            }

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(declarationBegin);
            stringBuilder.AppendLine(body);
            stringBuilder.AppendLine(declarationEnd);
            return stringBuilder.ToString();
        }

        internal int GetFilesNumber(string dir)
        {
            string axFolder = Path.Combine(dir, this.AxFolderName);
            if (!Directory.Exists(axFolder))
            {
                return 0;
            }
            string[] axFiles = Directory.GetFiles(axFolder);
            return axFiles.Length;
        }
    }
}