using System.IO;
using System.Text;

namespace Tekir
{
    public class FileEntry : IEntry
    {
        /// <summary>
        /// Path + filename (C:\Project\README.md)
        /// </summary>
        public string FullFileName;
        /// <summary>
        /// Default UTF8
        /// </summary>
        public Encoding Encoding { get; set; } = Encoding.UTF8;

        public string FileContent;

        public FileEntry()
        {

        }

        public FileEntry(string fullFileName,string fileContent)
        {
            FullFileName = fullFileName;
            FileContent = fileContent;
        }
        public FileEntry(string fullFileName, string fileContent, Encoding encoding)
        {
            FullFileName = fullFileName;
            FileContent = fileContent;
            Encoding = encoding;
        }

        /// <summary>
        /// Create or overwrite file
        /// </summary>
        public void Save()
        {
            File.WriteAllText(FullFileName, FileContent, Encoding);
        }
    }
}