using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProiectPAW
{
    public partial class Form1 : Form
    {
        private Actiune a;
        private List<Portofoliu> portofolii = new List<Portofoliu>();
        private List<Actiune> actiuni1 = new List<Actiune>();
        private List<Actiune> actiuni2 = new List<Actiune>();
        private List<Actiune> actiuni3 = new List<Actiune>();
        SqlConnection conexiune = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = Paww; Integrated Security = True; Connect Timeout = 30; Encrypt=False");

        internal List<Portofoliu> Portofolii { get { return portofolii ; } set { portofolii = value; } }
    
        SqlCommand command;
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();

            actiuni1.Add(new Actiune("Apple", 1100));
            actiuni1.Add(new Actiune("Tesla", 800));
            actiuni1.Add(new Actiune("Microsoft", 400));
            portofolii.Add(new Portofoliu(2300, actiuni1, "Portofoliu 1"));
            actiuni2.Add(new Actiune("Deloitte", 150));
            actiuni2.Add(new Actiune("Samsung", 500));
            actiuni2.Add(new Actiune("Xiaomi", 200));
            portofolii.Add(new Portofoliu(850, actiuni2, "Portofoliu 2"));
            actiuni3.Add(new Actiune("Google", 900));
            actiuni3.Add(new Actiune("Instragram", 300));
            actiuni3.Add(new Actiune("Facebook", 600));
            portofolii.Add(new Portofoliu(1800, actiuni3, "Portofoliu 3"));

            // connection = new SqlConnection(conexiune);

        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            if (cbActiuni.SelectedIndex != -1)
            {
                string portofoliu = cbActiuni.SelectedItem.ToString();
                foreach (Portofoliu p in portofolii)
                {
                    if (p.Nume.Equals(portofoliu))
                    {
                        lbActiuni.Items.Clear();
                        foreach (Actiune a in p.ActiuniExistente)
                        {
                            lbActiuni.Items.Add(a);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Va rog selectati un portofoliu");
            }
        }

        private void btnCumpara_Click(object sender, EventArgs e)
        {
            if (lbActiuni.SelectedIndex == -1)
            {
                MessageBox.Show("Nu ati selectat o actiune din portofoliu");
            }
            else
            {
                Actiune a = (Actiune)lbActiuni.SelectedItem;
                lbActiuni.Items.RemoveAt(lbActiuni.SelectedIndex);
                foreach (Portofoliu p in portofolii)
                {
                    if (p.ActiuniExistente.Contains(a))
                    {
                        p.cumparaActiune(a);
                        break;
                    }
                }

            }
        }

        private void lbActiuni_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbActiuni_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnActiuniDetinute_Click(object sender, EventArgs e)
        {
            // Portofoliu p = new Portofoliu(); 
            if (Portofoliu.actiuniDetinute.Count != 0)
            {
                MessageBox.Show(String.Join("\n", Portofoliu.actiuniDetinute));
            }
            else
            {
                MessageBox.Show("Nu ati cumparat nici o actiune");
            }
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvare();
        }

        private void restaurareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restaurare();
        }
        public void salvare()
        {
            saveFileDialog1.Filter = "(*.txt) | *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(Portofoliu.actiuniDetinute.Count.ToString());
                foreach (Actiune a in Portofoliu.actiuniDetinute)
                {
                    sw.WriteLine(a.Firma + "," + a.Pret);
                }
                sw.Close();
            }
        }

        public void restaurare()
        {
            openFileDialog1.Filter = "(*.txt) | *.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                int nr = Convert.ToInt32(sr.ReadLine());
                for (int i = 0; i < nr; i++)
                {
                    String l = sr.ReadLine();
                    String[] values = l.Split(',');
                    Actiune actiune = new Actiune(values[0], (int)Convert.ToInt64(values[1]));
                    foreach (Portofoliu p in portofolii)
                    {
                        if (p.ActiuniExistente.Contains(actiune))
                        {
                            p.cumparaActiune(actiune);
                        }

                    }
                }
                lbActiuni.Items.Clear();
                sr.Close();
            }
        }

        private void stocareToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Actiune a in Portofoliu.actiuniDetinute)
            {
                conexiune.Open();
                command = new SqlCommand("INSERT INTO IstoricActiuni VALUES (@nume, @valoare)", conexiune);
                command.Parameters.AddWithValue("@nume", a.Firma);

                command.Parameters.AddWithValue("@valoare", a.Pret);
                command.ExecuteNonQuery();
                conexiune.Close();
            }
        }

        private void regasireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conexiune.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                "SELECT * FROM IstoricActiuni", conexiune);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            Form3 form3 = new Form3(ds);
            form3.Show();

            conexiune.Close();
        }


        private void lbActiuni_click(object sender, EventArgs e)
        {
            if (lbActiuni.Text.Equals(""))
            {
                MessageBox.Show("Selectati un portofoliu de actiuni");
            }
            else
            {
                String s = "";
                foreach (Object obj in lbActiuni.Items)
                {
                    s += obj.ToString();
                }
                Clipboard.SetText(s);
            }
        }

        private void lbActiuni_dubluClicl(object sender, EventArgs e)
        {
            MessageBox.Show(Clipboard.GetText());
        }

        private void graficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(portofolii);
            form2.Show();
        }

        private void salvareXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {


            using (XmlWriter writer = XmlWriter.Create("actiuni.xml"))
            {
                // Start the root element
                writer.WriteStartDocument();
                writer.WriteStartElement("Actiuni");

                // Iterate through the list of books
                foreach (Actiune a in Portofoliu.actiuniDetinute)
                {

                    // Write the title element
                    writer.WriteStartElement("Firma");
                    writer.WriteString(a.Firma);
                    writer.WriteEndElement();

                    // Write the author element
                    writer.WriteStartElement("Pret");
                    writer.WriteString(a.Pret.ToString());
                    writer.WriteEndElement();

                    // End the book element
                    writer.WriteEndElement();
                }

                // End the root element
              //  writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        private void btnVinde_Click(object sender, EventArgs e)
        {
            Actiune a = new Actiune();  
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
