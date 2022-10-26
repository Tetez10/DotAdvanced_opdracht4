using System.Collections.Generic;
using System.Security.Policy;

namespace Oef1
{
    public partial class Form1 : Form
    {
         int teller = 0;
         int index = 0;


        public delegate void Showme(object rij);


        FouteRij<TeDoen> rij = new FouteRij<TeDoen>();
        List<System.Timers.Timer> timerList = new List<System.Timers.Timer>();


        // List time.
        List<DateTime> Dateslijst = new List<DateTime>();
        List<TeDoen> Datetaak = new List<TeDoen>();

       
        public Form1()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void VoegToe_Click(object sender, EventArgs e)
        {



            if (checkBox.Checked)
            {
                if (dateTimePicker1.Value > DateTime.Now)
                {

                    Datetaak.Add(new TeDoen(titel.Text, info.Lines, dateTimePicker1.Value));
                    Dateslijst.Add(dateTimePicker1.Value);

                    Timer();
                    titel.Text = "";
                    info.Text = "";

                    //RijBox.Text = Datetaak.ToString();
                }
                else
                {
                    MessageBox.Show("de datum moet verplicht in het toekomst zijn, doe opnieuw.");
                }

            }
            else
            {
                TeDoen tedoen = new TeDoen(titel.Text, info.Lines);
                rij.Voegtoe(tedoen);
                titel.Text = " ";
                info.Text = " ";
            }

        }
      

        public void Timer()
        {
            System.Timers.Timer Localtimer = new System.Timers.Timer(Wacht());
            Localtimer.Elapsed += TextBox;
            Localtimer.AutoReset = false;
            Localtimer.Start();
            timerList.Add(Localtimer);
        }

        public int Wacht()
        {
            TimeSpan tijd = dateTimePicker1.Value - DateTime.Now;
            return (int)tijd.TotalMilliseconds;
        }





        private void TextBox(object sender, EventArgs e)
        {
            foreach (DateTime date in Dateslijst)
            {
                if (date <= DateTime.Now)
                {
                    rij.Show(Datetaak[Dateslijst.IndexOf(date)]);
                    //first remove
                    Datetaak.RemoveAt(Dateslijst.IndexOf(date));


                    //second remove
                    Dateslijst.RemoveAt(Dateslijst.IndexOf(date));

                }

            }
        }




        private void Volgendetaak_Click(object sender, EventArgs e)
        {


            List<TeDoen> list = rij.Toon();
            
             // if statement om error te vermijden als ik verwijder + ik op volgende druk.
            if (list.Count != 0)
            {

             // na elke switch van taak toon het in de balkjes
             RijBox.Text = list.ElementAt(teller).Titel ;
             BeschrijvingBox.Lines = list.ElementAt(teller).Informatie;
             index = list.IndexOf(list.ElementAt(teller));

           




                if (list.ElementAt(teller).Tijdstip != null)
                {

                    dateTimePicker1.Value = (DateTime)list.ElementAt(teller).Tijdstip;
                    checkBox.Checked = true;
                }
                else
                {

                    dateTimePicker1.Value = DateTime.Now;
                    checkBox.Checked = false;
                }


                teller++;
                if (teller == list.Count)
                {
                    teller = 0;
                }
            }

        
    }

        private void verwijder_Click(object sender, EventArgs e)
        {
            rij.Verwijder(index);
            teller = 0;
            titel.Text = "";
            info.Text = "";

        }

        private void ZetAchteraan_Click(object sender, EventArgs e)
        {
            rij.ZitAchter(index);
            teller = 0;
            titel.Text = "";
            info.Text = "";

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

            dateTimePicker1.Visible = !dateTimePicker1.Visible;
        }
        private void show_form(object lijst)
        {
            // ik heb problemen met het voorschijnen van mijn taken in het juiste balk ik heb geen oplossing gevonden voor dit .. 
            RijBox.Text = lijst.ToString();

        }


        private void show_MessageBox(object lijst)
        {

            MessageBox.Show(lijst.ToString());

        }




        private void ToonForm_Click(object sender, EventArgs e)
        {         //default color
            if (ToonForm.BackColor == Color.Red)
            {
                ToonForm.BackColor = Color.Green;
                // werkt niet
                rij.show += new Showme(show_form);
                
            }
            else
            {
                ToonForm.BackColor = Color.Red;
                rij.show -= new Showme(show_form);
                
            }

        }

        private void toonMessagebox_Click(object sender, EventArgs e)
        {
            if (toonMessagebox.BackColor == Color.Red)
            {
                toonMessagebox.BackColor = Color.Green;

                rij.show += new Showme(show_MessageBox);

                
            }
            else
            {
                toonMessagebox.BackColor = Color.Red;

                rij.show -= new Showme(show_MessageBox);
            }
        }
    }


    }



    
    
    

