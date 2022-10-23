using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static Oef1.Form1;

namespace Oef1
{
    internal class Rij<T>
    {
        private List<T> rij = new List<T>();
        private List<T> rijcopie = new List<T>();
        private static int teller;
        public event Tonen tonen;



        public void InDeRij(T element)
        {
            rij.Add(element);
            WhenShow(element);


        }

        public void UitDeRij()
        {

            WhenShow(rij[0]);

            rij.Remove(rij[0]);



        }

        public void Toon()
        {
            teller++;
            WhenShow(rij[teller - 1]);

        }

        public void RijLeegMaken()
        {
            rij.Clear();
        }
        public override string ToString()
        {
            string lijst = "";

            foreach (T t in rij)
            {
                lijst += t.ToString() + " " + ",";
            }

            return lijst;
        }

        public bool CheckIfEmpty()
        {
            if (rij.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<T> lijstCopy()
        {
            rijcopie = rij.GetRange(0, rij.Count);

            return rijcopie;

        }

        public void ZetAchteraan()
        {
            if (rij.Count <= 0)
            {
                throw new Exception();
            }

            T element = rij[teller - 1];
            rij.RemoveAt(teller - 1);
            rij.Add(element);
            teller--;

            WhenShow(element);
        }


        public void WhenShow(object rij)
        {


            if (tonen != null)
            {
                tonen(rij);

            }

        }

    }
}

