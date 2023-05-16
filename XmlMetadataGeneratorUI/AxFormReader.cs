using System.Text;
using System.Xml;

namespace XmlMetadataGeneratorUI
{
    public class AxFormReader : AxBaseReader
    {
        protected readonly string Declaration = "/a:AxForm/a:SourceCode/Methods/Method[Name=\"classDeclaration\"]/Source";
        protected readonly string FormMethods = "//a:SourceCode/Methods/Method[position()>1]/Source";
        private XmlNamespaceManager nsmgr;

        public AxFormReader() : base("AxForm")
        {
        }

        protected override string ReadHeaderDeclaration(XmlDocument xmlDocument)
        {
            nsmgr = new XmlNamespaceManager(xmlDocument.NameTable);
            nsmgr.AddNamespace("a", "Microsoft.Dynamics.AX.Metadata.V6");

            XmlNodeList? xmlNodeMethodsList = xmlDocument.SelectNodes(Declaration, nsmgr);
            string body = GetMethodsSourceCode(xmlNodeMethodsList);

            return body;
        }

        private string ReadFormMethods(XmlDocument xmlDocument)
        {
            XmlNodeList? xmlNodeMethodsList = xmlDocument.SelectNodes(FormMethods, nsmgr);
            string body = GetMethodsSourceCode(xmlNodeMethodsList);
            return body;
        }

        protected override string ReadBody(XmlDocument xmlDocument)
        {
            StringBuilder stringBuilder = new StringBuilder();
            var formMethods = ReadFormMethods(xmlDocument);
            stringBuilder.AppendLine(formMethods);

            string xpathDataSources = "//a:SourceCode/DataSources/DataSource";
            XmlNodeList? xmlNodeDatasourcesList = xmlDocument.SelectNodes(xpathDataSources, nsmgr);
            foreach (XmlNode item in xmlNodeDatasourcesList)
            {
                string dataSourceCode = ReadDataSourceCode(item);
                stringBuilder.AppendLine(dataSourceCode);
            }

            return stringBuilder.ToString();
        }

        private string ReadDataSourceCode(XmlNode xmlDataSource)
        {
            string xpathName = "./Name";
            XmlNode? dataSourceNode = xmlDataSource.SelectSingleNode(xpathName);
            if (dataSourceNode == null)
            {
                throw new Exception("No se encontró el nombre del nodo DataSource");
            }

            string dataSourceName = dataSourceNode.InnerXml;

            string xpathSource = $"./Methods/Method/Source";
            XmlNodeList? xmlNodeMethodsList = xmlDataSource.SelectNodes(xpathSource, nsmgr);
            string methods = GetMethodsSourceCode(xmlNodeMethodsList);

            string body = MergeDataSourceCode(dataSourceName, methods);
            return body;
        }

        private string MergeDataSourceCode(string datasourceName, string body)
        {
            var datasourceHeader = $@"
    [DataSource]
    class {datasourceName}
    {{
        {body}
    }}";

            return datasourceHeader;
        }
    }
}