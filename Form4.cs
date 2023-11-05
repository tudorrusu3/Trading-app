using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class Form4 : Form
    {
        private Actiune a;
        private List<Portofoliu> portofolii;
        public Form4()
        {
            InitializeComponent();
        }
        private void btnNewAdauga_Click(object sender, EventArgs e)
        {
            // string Nume = textBox1.Text;
            //int Pret = int.Parse(textBox2.Text);
            MessageBox.Show("Actiune adaugata");
            this.Close();

        }
       
    }
}
