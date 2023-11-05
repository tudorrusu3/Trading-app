using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class Form2 : Form
    {
        private List<Portofoliu> portofolii;

        internal Form2(List<Portofoliu> portofolii)
        {
            InitializeComponent();
            this.portofolii = portofolii;
            chart1.Series.Clear();
            foreach (Portofoliu p in portofolii)
            {
                chart1.Series.Add(p.Nume);
                chart1.Series[p.Nume].Points.AddY(p.ActiuniExistente.Count);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private PrintDocument printDocument;

        private bool isDragging;
        private Panel draggedPanel;
        private Point dragStartPoint;

        private void chart1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Panel)))
            {
                draggedPanel.Location = chart1.PointToClient(new Point(e.X - dragStartPoint.X, e.Y - dragStartPoint.Y));
            }
            isDragging = false;
            Panel panel = (Panel)e.Data.GetData(typeof(Panel));
            MessageBox.Show("Alsl");
            foreach (var series in chart1.Series)
            {
                series.Color = panel.BackColor;
            }
        }

        private void chart1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Panel)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }
        private void InitializePrintDocument()
        {
            // Inițializați obiectul PrintDocument și atașați evenimentul PrintPage
            printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument1_PrintPage;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            InitializePrintDocument();
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            chart1.Printing.PrintPaint(e.Graphics, new Rectangle(100, 100, chart1.Width, chart1.Height));

        }


    }
}
