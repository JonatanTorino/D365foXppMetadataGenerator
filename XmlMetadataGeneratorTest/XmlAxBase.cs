using System.Xml;

namespace XmlMetadataGeneratorTest
{
    public abstract class XmlAxBase
    {
        protected readonly string Declaration = "//SourceCode/Declaration";
        protected readonly string Methods = "//SourceCode/Methods/Method/Source";

        public XmlAxBase(string sourceFilePath)
        {
            SourceFilePath = sourceFilePath;
        }

        private XmlAxBase()
        { }

        public string SourceFilePath { get; set; }

        public string ReadSource()
        {
            XmlDocument xmlDcoument = new XmlDocument();
            xmlDcoument.Load(SourceFilePath);
            return null;
        }
    }
}