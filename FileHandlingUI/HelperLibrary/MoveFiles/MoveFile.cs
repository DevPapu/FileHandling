using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{
    public class MoveFile
    {
        public string DirectoryPath { get; set; }
        public string CombinedDirectoryPath { get; set; }
        public string SourcePath { get; set; }
        public string TargetPath { get; set; }
        public string CombinedTargetPath { get; set; }
        public string CombinedSourceFile { get; set; }
        public void createDirectory(string FolderName, string targetPath)
        {
            DirectoryPath = targetPath;
            CombinedDirectoryPath = Path.Combine(@DirectoryPath, FolderName);

            if (!File.Exists(@CombinedDirectoryPath))
            {
                Directory.CreateDirectory(@CombinedDirectoryPath);
            }
        }
        public void moveFile(string folder, string fileName, string targetPath)
        {
            SourcePath = targetPath;
            TargetPath = targetPath + folder + @"\";

            CombinedSourceFile = Path.Combine(@SourcePath, fileName);
            CombinedTargetPath = Path.Combine(@TargetPath, fileName);

            File.Copy(@CombinedSourceFile, @CombinedTargetPath, true);

            File.Delete(@CombinedSourceFile);
        }
    }
}
