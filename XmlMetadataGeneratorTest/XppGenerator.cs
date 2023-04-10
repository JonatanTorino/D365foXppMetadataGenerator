using System.Text;

namespace XmlMetadataGeneratorTest
{
    public class XppGenerator
    {
        public static string MergeDeclarationAndBody(string classDeclaration, string classBody)
        {
            string[] declarationLines = classDeclaration.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            string declarationBegin = string.Join(Environment.NewLine, declarationLines.Take(declarationLines.Length - 1));
            string declarationEnd = declarationLines.Last();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(declarationBegin);
            stringBuilder.AppendLine(classBody.TrimEnd());
            stringBuilder.AppendLine(declarationEnd);
            return stringBuilder.ToString();
        }

        public static string RemoveCommentMarks(string sourceCode)
        {
            string[] lines = sourceCode.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            string output = string.Join(Environment.NewLine, lines.Skip(1).Take(lines.Length - 2));
            return output;
        }

        public static string FormDataSource(string source)
        {
            //string
            //StringBuilder stringBuilder = new StringBuilder();
            return null;
        }
    }
}