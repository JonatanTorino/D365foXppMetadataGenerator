namespace XmlMetadataGeneratorTest
{
    public class FileManagers
    {
        public FileManagers(string folderSource)
        {
            FolderSource = folderSource;
        }

        public string FolderDestination { get; set; }
        public string FolderSource { get; set; }
    }
}