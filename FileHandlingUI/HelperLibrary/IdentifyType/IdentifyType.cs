using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{
    public class IdentifyType
    {
        public string Folder { get; set; }
        public int Count { get; set; }
        public string FileSuffix(string file, ref List<string> FilesToSort)
        {
            Count = 0;
            foreach (string suffix in FilesToSort)
            {
                if (file.EndsWith(suffix))
                {
                    Folder = suffix;
                    break;
                }
                else
                {
                    Count += 1;
                }
            }
            if (Count > 23)
            {
                Folder = "OTHER FILES";
            }
            else if(Folder == "pdf")
            {
                Folder = "PDF";
            }
            else if (Folder == "doc" || Folder == "docx")
            {
                Folder = "WORD";
            }
            else if (Folder == "pptx" || Folder == "ppt")
            {
                Folder = "POWERPOINT";
            }
            else if (Folder == "txt")
            {
                Folder = "TEXT";
            }
            else if (Folder == "png" || Folder == "jpg" || Folder == "jpeg" || Folder == "jfif" || Folder == "gif")
            {
                Folder = "PICTURES";
            }
            else if (Folder == "exe")
            {
                Folder = "EXE";
            }
            else if (Folder == "xls" || Folder == "xlsx")
            {
                Folder = "EXCEL";
            }
            else if (Folder == "html")
            {
                Folder = "HTML-FILES";
            }
            else if (Folder == "php")
            {
                Folder = "PHP-FILES";
            }
            else if (Folder == "asf" || Folder == "avi" || Folder == "mov" || Folder == "mpg" || Folder == "mp4")
            {
                Folder = "VIDEOS";
            }
            else if (Folder == "mp3" || Folder == "wav")
            {
                Folder = "MUSIC";
            }
            else if (Folder == "zip")
            {
                Folder = "ZIP";
            }
            return Folder;
        }

    }
}

