using aaaa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Arthur : Kianoosh Vadaei
//for UI_DS_4th_Mini_Project


namespace Search_Engine
{
    

    public partial class Form1 : Form
    {
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
            Tree A = new Tree();
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
