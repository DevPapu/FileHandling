using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelperLibrary;

namespace UI
{
    public partial class Form1 : Form
    {
        public static IdentifyType Type = new IdentifyType();
        public static new MoveFile Move = new MoveFile();
        public static List<string> FilesToSort = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = false;
            txtPath.Visible = false;
            label3.Visible = false;
            checkedFileTypes.Visible = false;
            btnDo.Visible = false;
            label4.Visible = false;
            label8.Visible = true;
            screen1.Visible = false;
            screen2.Visible = false;
            label5.Visible = false;
            screen3.Visible = false;
            screen4.Visible = false;
            arrow1.Visible = false;
            arrow2.Visible = false;
            arrow3.Visible = false;
            arrow4.Visible = false;
            ex1.Visible = true;
            ex2.Visible = true;
            ex3.Visible = true;
            label6.Visible = false;
            button1.Visible = false;
        }

        private void btnHow_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = false;
            txtPath.Visible = false;
            label3.Visible = false;
            checkedFileTypes.Visible = false;
            btnDo.Visible = false;
            label4.Visible = true;
            label8.Visible = false;
            label5.Visible = false;
            screen1.Visible = false;
            screen2.Visible = false;
            screen3.Visible = false;
            screen4.Visible = false;
            arrow1.Visible = false;
            arrow2.Visible = false;
            arrow3.Visible = false;
            arrow4.Visible = false;
            ex1.Visible = false;
            ex2.Visible = false;
            ex3.Visible = false;
            label6.Visible = false;
            button1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = true;
            txtPath.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            checkedFileTypes.Visible = false;
            btnDo.Visible = false;
            label4.Visible = false;
            label8.Visible = true;
            label5.Visible = false;
            screen1.Visible = false;
            screen2.Visible = false;
            screen3.Visible = false;
            screen4.Visible = false;
            arrow1.Visible = false;
            arrow2.Visible = false;
            arrow3.Visible = false;
            arrow4.Visible = false;
            ex1.Visible = true;
            ex2.Visible = true;
            ex3.Visible = true;
            label6.Visible = false;
            button1.Visible = false;
        }

        private void btnGetToPage_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            txtPath.Visible = true;
            label3.Visible = true;
            checkedFileTypes.Visible = true;
            btnDo.Visible = true;
            label4.Visible = false; 
            label8.Visible = false;
            label5.Visible = false;
            screen1.Visible = false;
            screen2.Visible = false;
            screen3.Visible = false;
            screen4.Visible = false;
            arrow1.Visible = false;
            arrow2.Visible = false;
            arrow3.Visible = false;
            arrow4.Visible = false;
            ex1.Visible = false;
            ex2.Visible = false;
            ex3.Visible = false;
            label6.Visible = true;
            button1.Visible = true;
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            string sourcePath = txtPath.Text;
            GetFilesToSort();
            cycle(@sourcePath);
            btnDo.Text = "Your files have been sorted successfully!";
        }
        public static void cycle(string path)
        {
            foreach (string f in Directory.GetFiles(path))
            {
                var info = new FileInfo(f);
                string fileName = info.Name;
                string folder = Type.FileSuffix(fileName, ref FilesToSort);
                Move.createDirectory(folder, path);
                Move.moveFile(folder, fileName, path);
            }
        }
        public void GetFilesToSort()
        {
            foreach (string fileType in checkedFileTypes.CheckedItems)
            {
                if (fileType == "ALL")
                {
                    FilesToSort.Add("pdf"); FilesToSort.Add("docx"); FilesToSort.Add("doc");
                    FilesToSort.Add("pptx"); FilesToSort.Add("ppt"); FilesToSort.Add("txt");
                    FilesToSort.Add("png"); FilesToSort.Add("jpg"); FilesToSort.Add("jpeg");
                    FilesToSort.Add("jfif"); FilesToSort.Add("gif"); FilesToSort.Add("exe");
                    FilesToSort.Add("xls"); FilesToSort.Add("xlsx"); FilesToSort.Add("html");
                    FilesToSort.Add("php"); FilesToSort.Add("asf"); FilesToSort.Add("avi");
                    FilesToSort.Add("mov"); FilesToSort.Add("mpg"); FilesToSort.Add("mp4");
                    FilesToSort.Add("mp3"); FilesToSort.Add("wav"); FilesToSort.Add("zip");
                    break;
                }
                else if (fileType == "PDF")
                {
                    FilesToSort.Add("pdf");
                }
                else if (fileType == "WORD")
                {
                    FilesToSort.Add("docx"); FilesToSort.Add("doc");
                }
                else if (fileType == "POWERPOINT")
                {
                    FilesToSort.Add("pptx"); FilesToSort.Add("ppt");
                }
                else if (fileType == "EXCEL")
                {
                    FilesToSort.Add("xls"); FilesToSort.Add("xlsx");
                }
                else if (fileType == "TEXT")
                {
                    FilesToSort.Add("txt");
                }
                else if (fileType == "PICTURES")
                {
                    FilesToSort.Add("png"); FilesToSort.Add("jpg"); FilesToSort.Add("jpeg");
                    FilesToSort.Add("jfif"); FilesToSort.Add("gif");
                }
                else if (fileType == "VIDEOS")
                {
                    FilesToSort.Add("asf"); FilesToSort.Add("avi"); FilesToSort.Add("mov");
                    FilesToSort.Add("mpg"); FilesToSort.Add(" mp4");
                }
                else if (fileType == "MUSIC")
                {
                    FilesToSort.Add("mp3"); FilesToSort.Add("wav");
                }
                else if (fileType == "EXE")
                {
                    FilesToSort.Add("exe");
                }
                else if (fileType == "ZIP")
                {
                    FilesToSort.Add("zip");
                }
                else if (fileType == "HTML-FILE")
                {
                    FilesToSort.Add("html");
                }
                else if (fileType == "PHP-File")
                {
                    FilesToSort.Add("php");
                }
               
            }

        }

        private void btnGetPath_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            txtPath.Visible = false;
            label3.Visible = false;
            checkedFileTypes.Visible = false;
            btnDo.Visible = false;
            label4.Visible = false;
            label8.Visible = false;
            label5.Visible = true;
            screen1.Visible = true;
            screen2.Visible = true;
            screen3.Visible = true;
            screen4.Visible = true;
            arrow1.Visible = true;
            arrow2.Visible = true;
            arrow3.Visible = true;
            arrow4.Visible = true;
            ex1.Visible = false;
            ex2.Visible = false;
            ex3.Visible = false;
            label6.Visible = false;
            button1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            btnDo.Text = "Classify Files";
        }
    }
}
