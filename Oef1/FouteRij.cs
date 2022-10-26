using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static Oef1.Form1;

namespace Oef1
{
    internal class FouteRij<T>
    {
        private List<T> rij = new List<T>();
        private List<T> kopie = new List<T>();
        public event Form1.Showme show;
        int teller = -1;
        public FouteRij()
        {

        }
        public void Voegtoe(T f)
        {

            teller++;
            rij.Add(f);


        }
        public void Verwijderen()
        {
            if (teller >= 0)
            {
                rij.RemoveAt(rij.Count - 1);
                teller--;
            }


        }


        public List<T> Toon()
        {
            return rij;
        }
        public void ZitAchter(int index)
        {
            //lijst te doen gaar op de index gaan verwijderen.
            T teDoen = rij.ElementAt(index);
            rij.RemoveAt(index);
            rij.Add(teDoen);


        }
        public void Verwijder(int index)
        {
            T teDoen = rij.ElementAt(index);
            rij.RemoveAt(index);



        }
        public void Leegmaken()
        {
            rij.Clear();
        }
        public void CopyList()
        {
            kopie.Clear();
            //voor elke element in de rij die het copy gaat zien gaat die gaan kopieren naar de nieuwe list om te kopieren.
            foreach (T i in rij)
            {
                kopie.Add(i);
            }
        }
        public void Show(object rij)
        {

            
            if (show != null)
            {
                show(rij);

            }

        }

        public override string ToString()
        {
            string content = "";
            foreach (T i in rij)
                content += i + " ; ";
            return content;
        }

        public Boolean IsEmpty()
        {
            if (rij.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}

