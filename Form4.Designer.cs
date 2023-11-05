namespace ProiectPAW
{
    partial class Form4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbNewFirma = new System.Windows.Forms.Label();
            this.lbNewPret = new System.Windows.Forms.Label();
            this.btnNewAdauga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // lbNewFirma
            // 
            this.lbNewFirma.AutoSize = true;
            this.lbNewFirma.Location = new System.Drawing.Point(13, 21);
            this.lbNewFirma.Name = "lbNewFirma";
            this.lbNewFirma.Size = new System.Drawing.Size(32, 13);
            this.lbNewFirma.TabIndex = 2;
            this.lbNewFirma.Text = "Firma";
            // 
            // lbNewPret
            // 
            this.lbNewPret.AutoSize = true;
            this.lbNewPret.Location = new System.Drawing.Point(12, 102);
            this.lbNewPret.Name = "lbNewPret";
            this.lbNewPret.Size = new System.Drawing.Size(26, 13);
            this.lbNewPret.TabIndex = 3;
            this.lbNewPret.Text = "Pret";
            // 
            // btnNewAdauga
            // 
            this.btnNewAdauga.Location = new System.Drawing.Point(316, 46);
            this.btnNewAdauga.Name = "btnNewAdauga";
            this.btnNewAdauga.Size = new System.Drawing.Size(95, 45);
            this.btnNewAdauga.TabIndex = 4;
            this.btnNewAdauga.Text = "Adauga actiune";
            this.btnNewAdauga.UseVisualStyleBackColor = true;
            this.btnNewAdauga.Click += new System.EventHandler(this.btnNewAdauga_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewAdauga);
            this.Controls.Add(this.lbNewPret);
            this.Controls.Add(this.lbNewFirma);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbNewFirma;
        private System.Windows.Forms.Label lbNewPret;
        private System.Windows.Forms.Button btnNewAdauga;
    }
}