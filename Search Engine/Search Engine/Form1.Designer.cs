namespace Search_Engine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.xit_butt = new System.Windows.Forms.Button();
            this.mximize = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.title_pnl = new System.Windows.Forms.Panel();
            this.srch_box = new System.Windows.Forms.TextBox();
            this.srch_pnl = new System.Windows.Forms.Panel();
            this.srch_butt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.title_pnl.SuspendLayout();
            this.srch_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(60)))), ((int)(((byte)(103)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.xit_butt);
            this.panel1.Controls.Add(this.mximize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 40);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Gadugi", 11F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(327, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 40);
            this.button3.TabIndex = 7;
            this.button3.Text = "−";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // xit_butt
            // 
            this.xit_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xit_butt.FlatAppearance.BorderSize = 0;
            this.xit_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xit_butt.Font = new System.Drawing.Font("Gadugi", 11F);
            this.xit_butt.ForeColor = System.Drawing.Color.White;
            this.xit_butt.Location = new System.Drawing.Point(409, 0);
            this.xit_butt.Name = "xit_butt";
            this.xit_butt.Size = new System.Drawing.Size(41, 40);
            this.xit_butt.TabIndex = 5;
            this.xit_butt.Text = "✕";
            this.xit_butt.UseVisualStyleBackColor = true;
            this.xit_butt.Click += new System.EventHandler(this.xit_butt_Click);
            // 
            // mximize
            // 
            this.mximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mximize.FlatAppearance.BorderSize = 0;
            this.mximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mximize.Font = new System.Drawing.Font("Gadugi", 11F);
            this.mximize.ForeColor = System.Drawing.Color.White;
            this.mximize.Location = new System.Drawing.Point(368, 0);
            this.mximize.Name = "mximize";
            this.mximize.Size = new System.Drawing.Size(41, 40);
            this.mximize.TabIndex = 6;
            this.mximize.Text = "□";
            this.mximize.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(68, 26);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(327, 49);
            this.title.TabIndex = 1;
            this.title.Text = "G O O G O O L";
            // 
            // title_pnl
            // 
            this.title_pnl.Controls.Add(this.title);
            this.title_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_pnl.Location = new System.Drawing.Point(0, 40);
            this.title_pnl.Name = "title_pnl";
            this.title_pnl.Size = new System.Drawing.Size(450, 98);
            this.title_pnl.TabIndex = 2;
            // 
            // srch_box
            // 
            this.srch_box.Font = new System.Drawing.Font("Calibri Light", 20F);
            this.srch_box.Location = new System.Drawing.Point(77, 26);
            this.srch_box.Name = "srch_box";
            this.srch_box.Size = new System.Drawing.Size(251, 48);
            this.srch_box.TabIndex = 3;
            this.srch_box.Text = "TEST!";
            this.srch_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // srch_pnl
            // 
            this.srch_pnl.Controls.Add(this.srch_butt);
            this.srch_pnl.Controls.Add(this.srch_box);
            this.srch_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.srch_pnl.Location = new System.Drawing.Point(0, 138);
            this.srch_pnl.Name = "srch_pnl";
            this.srch_pnl.Size = new System.Drawing.Size(450, 87);
            this.srch_pnl.TabIndex = 4;
            // 
            // srch_butt
            // 
            this.srch_butt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.srch_butt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("srch_butt.BackgroundImage")));
            this.srch_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.srch_butt.FlatAppearance.BorderSize = 0;
            this.srch_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srch_butt.Location = new System.Drawing.Point(329, 26);
            this.srch_butt.Name = "srch_butt";
            this.srch_butt.Size = new System.Drawing.Size(55, 31);
            this.srch_butt.TabIndex = 5;
            this.srch_butt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 244);
            this.Controls.Add(this.srch_pnl);
            this.Controls.Add(this.title_pnl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.title_pnl.ResumeLayout(false);
            this.title_pnl.PerformLayout();
            this.srch_pnl.ResumeLayout(false);
            this.srch_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button xit_butt;
        private System.Windows.Forms.Button mximize;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel title_pnl;
        private System.Windows.Forms.TextBox srch_box;
        private System.Windows.Forms.Panel srch_pnl;
        private System.Windows.Forms.Button srch_butt;
    }
}

