using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tree;


//Arthur : Kianoosh Vadaei
//for UI_DS_4th_Mini_Project


namespace Search_Engine
{
    


    public partial class Form1 : Form
    {

        List<Tree<char>> TreeList = new List<Tree<char>>();


        string delete_Punctuation(ZipArchiveEntry entry)
        {
            using (StreamReader writer = new StreamReader(entry.Open()))
            {
                string result = string.Empty;
                string s = writer.ReadToEnd();

                foreach (char c in s)
                {
                    if (!char.IsPunctuation(c) && c != '>')
                        result += c;
                    else
                        result += ' ';

                }

                for (int i = 0; i < result.Length - 1; i++)
                {
                    if (result[i] == ' ' && result[i + 1] == ' ')
                    {
                        result = result.Remove(i, 1);
                        i--;
                    }
                }
                //Console.WriteLine(">>" + result);
                return result;
            }
            //WriteFiles(entry, result);
        }
        void ReadFiles()
        {
            using (FileStream zipToOpen = new FileStream(@"D:\Private\uni\Coding\Search engine\project-4-Hsoonaik\Search Engine\files\the-20-newsgroups2.zip", FileMode.Open))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        Console.WriteLine(entry.Name);
                        string s = delete_Punctuation(entry);
                        MessageBox.Show(s);
                        add_to_tree(s);
                    }
                }
            }
        }


        void add_to_tree(string s)
        {
            List<string> q = s.Split().ToList();
            Console.WriteLine(q[3]);

        }

        //void WriteFiles(ZipArchiveEntry entry, string content)
        //{
        //    Console.WriteLine(content);
        //    using (StreamWriter writer = new StreamWriter(entry.Open()))
        //    {
                
        //        writer.Write("asd");
        //    }                       

        //}


        void ui_settings()
        {
            title.Location = new System.Drawing.Point((title_pnl.Width - title.Width) / 2, (title_pnl.Height - title.Height) / 2 + 20);
            srch_box.Location = new System.Drawing.Point((srch_pnl.Width - srch_box.Width) / 2 - 10, (srch_pnl.Height - srch_box.Height) / 2);
            srch_butt.Height = srch_box.Height;
            srch_butt.Location = new System.Drawing.Point(srch_box.Width + srch_box.Location.X + 1, (srch_pnl.Height - srch_butt.Height) / 2);
            srch_butt.Cursor = Cursors.Hand;
        }
        public Form1()
        {
            InitializeComponent();
            ui_settings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tree<int> A = new Tree<int>();

            A.getRoot().val = 5;
            A.getRoot().addChild(5);
            A.getRoot().addChild(6, 0);
            ReadFiles();
        }


        #region EVENTS
        private void xit_butt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        #endregion


    }
}
