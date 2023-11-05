using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProiectPAW
{
    internal class Actiune : IComparable<Actiune>,ICloneable,Fluctuatie
    {
        private string firma;
        private int pret;
        public Actiune()
        {
            firma = "";
            pret = -1;
        }
        public Actiune(string firma, int pret)
        {
            this.firma = firma;
            this.pret = pret;
        }
        public string Firma { get { return firma; } set { firma = value; } }
        public int Pret { get { return pret;} set { pret = value; } }
        public static Actiune operator ++(Actiune a)
        {
            a.pret++;
            return a;
        }
        public static Actiune operator --(Actiune a)
        {
            a.pret--;
            return a;
        }
        public static bool operator >(Actiune a, Actiune b)
        {
            return a.pret > b.pret;
        }
        public static bool operator <(Actiune a, Actiune b)
        {
            return a.pret < b.pret;
        }
        public int CompareTo(Actiune actiune)
        {
            return (int)(pret-actiune.pret);
        }
        public object Clone()
        {
            Actiune a = new Actiune(firma,pret);
            return a;
        }
        public float Crestere()
        {
            if (pret < 5)
            {
                return (float)(pret + 0.2 * pret);
            }
            else if (pret > 50)
            {
                return (float)(pret + 0.1 * pret);
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return "O actiune la " + firma + " valoreaza " + pret + " de lei";
        }
    }
}
