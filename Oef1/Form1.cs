using System.Security.Policy;

namespace Oef1
{
    public partial class Form1 : Form
    {
         int teller = 0;
         int index = 0;


        public delegate void Toon(object rij);


        FouteRij<TeDoen> rij = new FouteRij<TeDoen>();

        List<System.Timers.Timer> timerList = new List<System.Timers.Timer>();



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
        public int Wacht()
        {
            TimeSpan tijd = dateTimePicker1.Value - DateTime.Now;
            System.Threading.Thread.Sleep((int)tijd.TotalMinutes);
            return (int)tijd.TotalMilliseconds;
        }


        public void Timer()
        {
            System.Timers.Timer Localtimer = new System.Timers.Timer(Wacht());
            Localtimer.Elapsed += TextBox;
            Localtimer.AutoReset = false;
            Localtimer.Start();
            timerList.Add(Localtimer);
        }




        private void TextBox(object sender, EventArgs e)
        {
            foreach (DateTime date in Dateslijst)
            {
                if (date <= DateTime.Now)
                {
                    rij.Show(Datetaak[Dateslijst.IndexOf(date)]);

                    Datetaak.RemoveAt(Dateslijst.IndexOf(date));
                    Dateslijst.RemoveAt(Dateslijst.IndexOf(date));

                }

            }
        }




        private void Volgendetaak_Click(object sender, EventArgs e)
        {

            List<TeDoen> list = rij.Toon();
            titel.Text = list.ElementAt(teller).Titel;
            info.Lines = list.ElementAt(teller).Informatie;
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

            info.Text = lijst.ToString();

        }


        private void show_MessageBox(object lijst)
        {

            MessageBox.Show(lijst.ToString());

        }




        private void ToonForm_Click(object sender, EventArgs e)
        {
            if (ToonForm.BackColor == Color.Red)
            {
                ToonForm.BackColor = Color.Green;
                rij.tonen += new Toon(show_form);
            }
            else
            {
                ToonForm.BackColor = Color.Red;
                rij.tonen -= new Toon(show_form);
            }

        }

        private void toonMessagebox_Click(object sender, EventArgs e)
        {
            if (toonMessagebox.BackColor == Color.Red)
            {
                toonMessagebox.BackColor = Color.Green;
                rij.tonen += new Toon(show_MessageBox);
            }
            else
            {
                toonMessagebox.BackColor = Color.Red;
                rij.tonen -= new Toon(show_MessageBox);
            }
        }
    }


    }



    
    
    

