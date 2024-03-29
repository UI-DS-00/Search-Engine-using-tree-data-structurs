﻿using System;
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

        List<MyTree> TreeList = new List<MyTree>();


        string delete_Punctuation(ZipArchiveEntry entry)
        {
            using (StreamReader writer = new StreamReader(entry.Open()))
            {
                string result = string.Empty;
                string s = writer.ReadToEnd();

                foreach (char c in s)
                {
                    if (char.IsLetter(c))
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
                    int tmpI = 1;
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        //Console.WriteLine(entry.Name);
                        string s = delete_Punctuation(entry);
                        //MessageBox.Show(s);
                        add_to_tree(s , entry.FullName);
                        Console.WriteLine(tmpI + " " + entry.Name + " Done!");

                        tmpI++;
                    }
                }
            }
        }
        void add_to_tree(string s , string FileName)
        {
            List<string> WordList = s.Split().ToList();
            MyTree tmp = new MyTree();
            foreach (string word in WordList)
                tmp.insert(word);
            tmp.FileName = FileName;
            
            TreeList.Add(tmp);
        }
        void ui_settings()
        {
            title.Location = new System.Drawing.Point((title_pnl.Width - title.Width) / 2, (title_pnl.Height - title.Height) / 2 + 20);
            srch_box.Location = new System.Drawing.Point((srch_pnl.Width - srch_box.Width) / 2 - 10, (srch_pnl.Height - srch_box.Height) / 2);
            srch_butt.Height = srch_box.Height;
            srch_butt.Location = new System.Drawing.Point(srch_box.Width + srch_box.Location.X + 1, (srch_pnl.Height - srch_butt.Height) / 2);
            srch_butt.Cursor = Cursors.Hand;
        }

        List<string> search(string w)
        {
            List<string> FileNames = new List<string>();
            try
            {
                foreach (MyTree tree in TreeList)
                    if (tree.search(w))
                        FileNames.Add(tree.FileName);
            }
            catch(Exception)
            {
                return null;
            }
            return FileNames;
        }


        string search_result(string In)
        {
            List<string> list = new List<string>();
            list = search(In);
            if (list == null)
            {

                //MessageBox.Show("Pleas Enter a valid value", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "ex*";
            }
            else if (list.Count == 0)
                return "null*";
            //MessageBox.Show("The word could not be found !", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string tmp = String.Join("  ,  ", list);

                return tmp;
            }
        }

        string multiple_search_engine(string In)
        {
            List<string> words = In.Split().ToList();
            List<string> files = new List<string>();
            List<string> filesP = new List<string>();
            List<string> filesM = new List<string>();
            List<string> diff = new List<string>();

            foreach (string word in words)
            {
                //Console.WriteLine(word);
                if (word[0] != '+' && word[0] != '-' && word[0] !=' ')
                {
                    files.Add(search_result(word));
                }
                else if(word[0] == '+')
                {
                    string tmp = word.Substring(1);
                    //Console.WriteLine(tmp);
                    filesP.Add(search_result(tmp));
                }
                else if (word[0] == '-')
                {
                    string tmp = word.Substring(1);
                    //Console.WriteLine(tmp);
                    filesM.Add(search_result(tmp));

                }
            }

            string result = files[0];
            string resultP = "";
            foreach (string file in files)
                result.Intersect(file);
            foreach (string file in filesP)
                resultP.Union(file);
            result.Intersect(resultP);
            foreach (string file in filesM)
            {
                //Console.WriteLine(">>> " + file + "\n" , result);
                IEnumerable<string> set1 = result.Split(' ').Distinct();
                IEnumerable<string> set2 = file.Split(' ').Distinct();

                diff = set1.Except(set2).ToList();

            }
            var r = string.Join(" ", diff.ToArray());
            Console.WriteLine(r);
            return result;

        }

        public Form1()
        {
            InitializeComponent();
            ui_settings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFiles();
            tmp_lbl.Select();
            tmp_lbl.Focus();
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

        private void srch_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void srch_box_Enter(object sender, EventArgs e)
        {
            if (srch_box.Text == "Search")
            {
                srch_box.Clear();
                srch_box.ForeColor = Color.Black;
            }

        }

        private void srch_box_Leave(object sender, EventArgs e)
        {
            if(srch_box.Text == "")
            {
                srch_box.ForeColor = Color.Gray;
                srch_box.Text = "Search";
            }
        }

        private void srch_butt_Click(object sender, EventArgs e)
        {

            //Console.WriteLine(list[5]);
            if (!srch_box.Text.Contains("+") && !srch_box.Text.Contains("-") && !srch_box.Text.Contains(" "))
            {
                if (srch_box.Text != "Search" && srch_box.Text != "")
                {
                    if (!srch_box.Text.Contains(" ") || !srch_box.Text.Contains("+") || !srch_box.Text.Contains("-"))
                    {
                        string tmp =  search_result(srch_box.Text);
                        if(tmp == "ex*")
                            MessageBox.Show("Pleas Enter a valid value", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if(tmp == "null*")
                            MessageBox.Show("The word could not be found !", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            MessageBox.Show("These files contains Entered word :\n" + tmp 
                                ,"Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Pleas Enter a valid value", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (srch_box.Text != "Search" && srch_box.Text != "")
                {
                    string r = multiple_search_engine(srch_box.Text);
                    MessageBox.Show("These files contains Entered word :\n\n" + r
                        , "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Pleas Enter a valid value", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
                

            

            srch_box.Text = "Search";
            srch_box.ForeColor = Color.Gray;
            tmp_lbl.Select();
            tmp_lbl.Focus();

        }

        private void advncd_opt_lbl_Click(object sender, EventArgs e)
        {
            //advncd_opt_lbl.Hide();
            if (this.Height <= 250)
            {
                this.Size = new Size(this.Width, this.Height + 200);
            }
            else
            {
                this.Size = new Size(this.Width, this.Height - 200);
                advncd_opt_lbl.Text = "Advanced Option";
            }

        }

        private void srch_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mximize_Click(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmp_lbl_Click(object sender, EventArgs e)
        {

        }

        private void title_pnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
