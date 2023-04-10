namespace XmlMetadataGeneratorTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string fileFullPath = @"K:\AosService\PackagesLocalDirectory\ApplicationSuite\Foundation\AxClass\RetailTransactionPaymentsHelperExtensions.xml";
        }

        /*
            //string aosPath = @"K:\AosService\PackagesLocalDirectory";
            //string modelPath = @"ApplicationSuite\Foundation\AxClass\RetailTransactionPaymentsHelperExtensions.xml";
            //string Path = @"";
            //string filePath = @"";

            XmlDocument xmlDcoument = new XmlDocument();
            xmlDcoument.Load(fileFullPath);

            string xppMetadataContent = string.Empty;

            XmlNode? xmlNodeDeclaration = xmlDcoument.DocumentElement.SelectSingleNode("//SourceCode/Declaration");
            //string sourceCodeDeclaration = RemoveCommentMarks(xmlNodeDeclaration.InnerText);

            XmlNodeList? xmlNodeMethodsList = xmlDcoument.DocumentElement.SelectNodes("//SourceCode/Methods/Method/Source");
            //string body = GetBodySourceCode(xmlNodeMethodsList);

            //string xppContent = MergeDeclarationAndBody(sourceCodeDeclaration, body);
            //Console.WriteLine(xppContent);
        */

        //private static string GetBodySourceCode(XmlNodeList? xmlNodeMethodsList)
        //{
        //    string body = string.Empty;
        //    if (xmlNodeMethodsList != null)
        //    {
        //        StringBuilder stringBuilder = new StringBuilder();
        //        foreach (XmlNode xmlNode in xmlNodeMethodsList)
        //        {
        //            string sourceCode = RemoveCommentMarks(xmlNode.InnerText);
        //            stringBuilder.AppendLine(sourceCode);
        //        }
        //        body = stringBuilder.ToString();
        //    }

        //    return body;
        //}

        //private static string MergeDeclarationAndBody(string classDeclaration, string classBody)
        //{
        //    string[] declarationLines = classDeclaration.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
        //    string declarationBegin = string.Join(Environment.NewLine, declarationLines.Take(declarationLines.Length - 1));
        //    string declarationEnd = declarationLines.Last();

        //    StringBuilder stringBuilder = new StringBuilder();
        //    stringBuilder.AppendLine(declarationBegin);
        //    stringBuilder.AppendLine(classBody.TrimEnd());
        //    stringBuilder.AppendLine(declarationEnd);
        //    return stringBuilder.ToString();
        //}
    }
}