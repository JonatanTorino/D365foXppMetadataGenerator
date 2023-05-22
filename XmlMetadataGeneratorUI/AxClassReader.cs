using System.Xml;

namespace XmlMetadataGeneratorUI
{
    public class AxClassReader : AxBaseReader
    {
        public AxClassReader() : base("AxClass")
        {
        }

        public AxClassReader(string axFolderName) : base(axFolderName)
        {
        }

        protected override string ReadHeaderDeclaration(XmlDocument xmlDocument)
        {
            XmlNode? xmlNodeDeclaration = xmlDocument.SelectSingleNode("//SourceCode/Declaration");

            string sourceCodeDeclaration = null;
            if (xmlNodeDeclaration != null)
            {
                sourceCodeDeclaration = xmlNodeDeclaration.InnerText.Trim();
            }
            return sourceCodeDeclaration;
        }

        protected override string ReadBody(XmlDocument xmlDocument)
        {
            XmlNodeList? xmlNodeMethodsList = xmlDocument.SelectNodes("//SourceCode/Methods/Method/Source");
            string body = GetMethodsSourceCode(xmlNodeMethodsList);
            return body;
        }
    }
}