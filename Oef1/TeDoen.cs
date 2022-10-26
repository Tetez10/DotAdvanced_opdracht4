using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef1
{
    internal class TeDoen
    {
       
        delegate void Showme(string titel, string inhoud, Boolean dringend);
        public int id
        {
            get { _volgnummer++; return _volgnummer; }
            set { _volgnummer = value; }
        }
        
        public DateTime? Tijdstip = null;

        private int _volgnummer = 0;

        public string Titel { get; set; }

        public string[] Informatie { get; set; }
        
        
        public TeDoen(string titel, string[] informatie)
        {
            Titel = titel;
            Informatie = informatie;
        }
        public TeDoen(string titel, string[] informatie, DateTime tijdstip)
        {
            Titel = titel;
            Tijdstip = tijdstip;
            Informatie = informatie;
        }
        public override string ToString()

        {
            string text = "";

            foreach (string line in Informatie)
            {
                text += line.ToString() + "   ";

            }

            if (Tijdstip == null)
            {
                return  id + ", : " + Titel  + text;
            }
            else
            {
                return  id + "  ,   : " + Tijdstip + " ,  : " + Titel + "  ,  : " + text;
            }


        }

    }
}
 
