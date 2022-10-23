using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef1
{
    internal class TeDoen
    {
        private int Id { get; set; }
        private static int teller;
        private DateTime? Tijdsstip { get; set; }
        private string Title { get; set; }
        private string[] Informatie;


        public TeDoen(DateTime tijdstip, string title, string[] informatie)
        {
            teller++;

            Id = teller;

            if (tijdstip >= DateTime.Now)
            {
                Tijdsstip = tijdstip;

            }
            else
            {
                Tijdsstip = null;
            }

            Title = title;
            Informatie = informatie;

        }
        public TeDoen(string title, string[] beschrijving)
        {
            teller++;
            Id = teller;
            Title = title;
            Informatie = beschrijving;

        }

        public override string ToString()

        {
            string result = "";

            foreach (string s in Informatie)
            {
                result += s.ToString() + "\n";

            }

            if (Tijdsstip == null)
            {
                return "id" + Id + " title : " + Title + " informatie : " + result;
            }
            else
            {
                return "id" + Id + " tijdstip: " + Tijdsstip + " title : " + Title + " informatie : " + result;
            }


        }



    }
}
 
