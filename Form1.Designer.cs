namespace ProiectPAW
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
            this.lbActiune = new System.Windows.Forms.Label();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.btnCumpara = new System.Windows.Forms.Button();
            this.btnActiuniDetinute = new System.Windows.Forms.Button();
            this.cbActiuni = new System.Windows.Forms.ComboBox();
            this.lbActiuni = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaDeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regasireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbActiune
            // 
            this.lbActiune.AutoSize = true;
            this.lbActiune.Location = new System.Drawing.Point(70, 41);
            this.lbActiune.Name = "lbActiune";
            this.lbActiune.Size = new System.Drawing.Size(42, 13);
            this.lbActiune.TabIndex = 0;
            this.lbActiune.Text = "Actiuni:";
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(414, 36);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(157, 37);
            this.btnAfiseaza.TabIndex = 2;
            this.btnAfiseaza.Text = "Afiseaza portofolii";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // btnCumpara
            // 
            this.btnCumpara.Location = new System.Drawing.Point(630, 83);
            this.btnCumpara.Name = "btnCumpara";
            this.btnCumpara.Size = new System.Drawing.Size(135, 50);
            this.btnCumpara.TabIndex = 3;
            this.btnCumpara.Text = "Cumpara actiune";
            this.btnCumpara.UseVisualStyleBackColor = true;
            this.btnCumpara.Click += new System.EventHandler(this.btnCumpara_Click);
            // 
            // btnActiuniDetinute
            // 
            this.btnActiuniDetinute.Location = new System.Drawing.Point(630, 156);
            this.btnActiuniDetinute.Name = "btnActiuniDetinute";
            this.btnActiuniDetinute.Size = new System.Drawing.Size(135, 54);
            this.btnActiuniDetinute.TabIndex = 4;
            this.btnActiuniDetinute.Text = "Actiuni detinute";
            this.btnActiuniDetinute.UseVisualStyleBackColor = true;
            this.btnActiuniDetinute.Click += new System.EventHandler(this.btnActiuniDetinute_Click);
            // 
            // cbActiuni
            // 
            this.cbActiuni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActiuni.FormattingEnabled = true;
            this.cbActiuni.Items.AddRange(new object[] {
            "Portofoliu 1",
            "Portofoliu 2",
            "Portofoliu 3"});
            this.cbActiuni.Location = new System.Drawing.Point(152, 38);
            this.cbActiuni.Margin = new System.Windows.Forms.Padding(2);
            this.cbActiuni.Name = "cbActiuni";
            this.cbActiuni.Size = new System.Drawing.Size(109, 21);
            this.cbActiuni.TabIndex = 7;
            // 
            // lbActiuni
            // 
            this.lbActiuni.FormattingEnabled = true;
            this.lbActiuni.Location = new System.Drawing.Point(33, 94);
            this.lbActiuni.Margin = new System.Windows.Forms.Padding(2);
            this.lbActiuni.Name = "lbActiuni";
            this.lbActiuni.Size = new System.Drawing.Size(538, 160);
            this.lbActiuni.TabIndex = 8;
            this.lbActiuni.Click += new System.EventHandler(this.lbActiuni_click);
            this.lbActiuni.DoubleClick += new System.EventHandler(this.lbActiuni_dubluClicl);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.graficToolStripMenuItem,
            this.bazaDeDateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem,
            this.restaurareToolStripMenuItem,
            this.salvareXMLToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvareToolStripMenuItem.Text = "Salvare";
            this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
            // 
            // restaurareToolStripMenuItem
            // 
            this.restaurareToolStripMenuItem.Name = "restaurareToolStripMenuItem";
            this.restaurareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restaurareToolStripMenuItem.Text = "Afisare";
            this.restaurareToolStripMenuItem.Click += new System.EventHandler(this.restaurareToolStripMenuItem_Click);
            // 
            // salvareXMLToolStripMenuItem
            // 
            this.salvareXMLToolStripMenuItem.Name = "salvareXMLToolStripMenuItem";
            this.salvareXMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvareXMLToolStripMenuItem.Text = "XML";
            this.salvareXMLToolStripMenuItem.Click += new System.EventHandler(this.salvareXMLToolStripMenuItem_Click);
            // 
            // graficToolStripMenuItem
            // 
            this.graficToolStripMenuItem.Name = "graficToolStripMenuItem";
            this.graficToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.graficToolStripMenuItem.Text = "Grafic";
            this.graficToolStripMenuItem.Click += new System.EventHandler(this.graficToolStripMenuItem_Click);
            // 
            // bazaDeDateToolStripMenuItem
            // 
            this.bazaDeDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stocareToolStripMenuItem,
            this.regasireToolStripMenuItem});
            this.bazaDeDateToolStripMenuItem.Name = "bazaDeDateToolStripMenuItem";
            this.bazaDeDateToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.bazaDeDateToolStripMenuItem.Text = "Baza de date";
            // 
            // stocareToolStripMenuItem
            // 
            this.stocareToolStripMenuItem.Name = "stocareToolStripMenuItem";
            this.stocareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stocareToolStripMenuItem.Text = "Introducere";
            this.stocareToolStripMenuItem.Click += new System.EventHandler(this.stocareToolStripMenuItem_Click);
            // 
            // regasireToolStripMenuItem
            // 
            this.regasireToolStripMenuItem.Name = "regasireToolStripMenuItem";
            this.regasireToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.regasireToolStripMenuItem.Text = "Afisare";
            this.regasireToolStripMenuItem.Click += new System.EventHandler(this.regasireToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(630, 230);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(135, 47);
            this.btnAdauga.TabIndex = 10;
            this.btnAdauga.Text = "Adauga actiune";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnVinde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lbActiuni);
            this.Controls.Add(this.cbActiuni);
            this.Controls.Add(this.btnActiuniDetinute);
            this.Controls.Add(this.btnCumpara);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.lbActiune);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbActiune;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.Button btnCumpara;
        private System.Windows.Forms.Button btnActiuniDetinute;
        private System.Windows.Forms.ComboBox cbActiuni;
        private System.Windows.Forms.ListBox lbActiuni;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bazaDeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stocareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regasireToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnAdauga;
    }
}

