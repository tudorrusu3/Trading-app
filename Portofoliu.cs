using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProiectPAW
{
    internal class Portofoliu : IComparable<Portofoliu>
    {
        private String nume;
        private int valoare;
        public static List<Actiune> actiuniDetinute = new List<Actiune>();
        private List<Actiune> actiuniExistente = new List<Actiune>();
        public int Valoare
        { get  { return valoare; } set { valoare = value; } }
      //  public List<Actiune> ActiuniDetinute {  get { return actiuniDetinute; } set { actiuniDetinute = value; } }
        public List<Actiune> ActiuniExistente { get { return actiuniExistente; } set { actiuniExistente = value; } }
        public String Nume { get { return nume; } set {  nume = value;} }
        public Portofoliu()
        {
            nume="";
        }
        public Portofoliu(int valoare,List<Actiune> actiuni,string nume)
        {
            this.valoare = valoare;
            this.actiuniExistente = actiuni;
            this.nume = nume;
        }
        public static Portofoliu operator --(Portofoliu portofoliu)
        {
            portofoliu.actiuniExistente.RemoveAt(portofoliu.actiuniExistente.Count - 1);
            return portofoliu;
        }
        public Actiune this[int index]
        {
            get
            {
                if (index > 0 || index < actiuniDetinute.Count)
                {
                    return actiuniDetinute[index];
                }
                return null;
            }
            set
            {
                if (index > 0 || index < actiuniDetinute.Count)
                {
                    actiuniDetinute[index] = value;
                }
            }
        }
        public void cumparaActiune(Actiune a)
        {
            actiuniDetinute.Add(a);
            actiuniExistente.Remove(a);
        }
        public void vindeActiune(Actiune a)
        {
            actiuniDetinute.Remove(a);
            actiuniExistente.Add(a);
        }
        public int CompareTo(Portofoliu portofoliu)
        {
            return actiuniExistente.Count - portofoliu.actiuniExistente.Count;
        }
    }
}
