using System.Xml;

namespace XmlMetadataGeneratorUI
{
    public class AxEntityReader : AxBaseReader
    {
        public AxEntityReader() : base("AxDataEntityView")
        {
        }

        public AxEntityReader(string axFolderName) : base(axFolderName)
        {
        }

        protected override string ReadHeaderDeclaration(XmlDocument xmlDocument)
        {
            XmlNode xmlNodeDeclaration = xmlDocument.SelectSingleNode("//AxDataEntityView/SourceCode/Declaration");
            if (xmlNodeDeclaration != null)
            {
                return xmlNodeDeclaration.InnerText.Trim();
            }

            return string.Empty;
        }

        protected override string ReadBody(XmlDocument xmlDocument)
        {
            XmlNodeList xmlNodeMethodsList = xmlDocument.SelectNodes("//AxDataEntityView/SourceCode/Methods/Method/Source");
            return GetMethodsSourceCode(xmlNodeMethodsList);
        }
    }
}

