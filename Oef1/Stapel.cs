﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef1
{
    internal class Stapel <T>
    {
        private List<T> Stapellijst = new List<T>();
        private List<T> stapellijstCopy = new List<T>();


        public void OpDeStapel(T toeTeVoegen)
        {
            Stapellijst.Add(toeTeVoegen);
        }

        public T vanDeStapel()
        {
            if (Stapellijst.Count <= 0)
            {
                throw new ArgumentNullException();
            }

            T updatedLijst = Stapellijst[Stapellijst.Count - 1];
            Stapellijst.RemoveAt(Stapellijst.Count - 1);

            return updatedLijst;
        }

        public void StapelLeegMaken()
        {
            Stapellijst.Clear();
        }


        public bool IsAanwezigOpStapel(T zoeken )
        {
            foreach (T elements in Stapellijst)
            {

                if (elements.ToString() == zoeken.ToString())
                {

                    return true;

                }

            }

            return false;

        }

        public override string ToString()
        {
            string lijst = "";

            foreach (T t in Stapellijst)
            {
                lijst += t.ToString() + " " + ",";
            }

            return lijst;
        }

        public List<T> lijstCopy()
        {
            stapellijstCopy = Stapellijst.GetRange(0, Stapellijst.Count);

            return stapellijstCopy;
        }


    }
}
