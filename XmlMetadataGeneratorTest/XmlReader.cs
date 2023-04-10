using System.Xml;

namespace XmlMetadataGeneratorTest
{
    public class XmlReader
    {
        public static string GetDeclaration(XmlDocument xmlDcoument)
        {
            XmlNode? xmlNodeDeclaration = xmlDcoument.DocumentElement.SelectSingleNode("//SourceCode/Declaration");
            return xmlNodeDeclaration == null ? string.Empty : xmlNodeDeclaration.InnerText;
        }

        private static IList<string> GetMethodsSourceCode(XmlNodeList? xmlNodeMethodsList)
        {
            IList<string> methods = new List<string>();
            if (xmlNodeMethodsList != null)
            {
                methods = xmlNodeMethodsList.Cast<XmlNode>().Select(x => x.InnerText).ToList();
            }
            return methods;
        }
    }
}