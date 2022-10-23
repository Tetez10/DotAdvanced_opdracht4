using System.Security.Policy;

namespace Oef1
{
    public partial class Form1 : Form
        {

        public delegate void Tonen(object rij); 
        public Form1()
        {
            InitializeComponent();
            inputDate.Visible = false;
        }
        private List<System.Timers.Timer> LijstVanTimers = new List<System.Timers.Timer>();
        private Rij<TeDoen> rij = new Rij<TeDoen>();
        private List<TeDoen> lijstvanObjecten = new List<TeDoen>();
        private List<DateTime> lijstDatum = new List<DateTime>();
          public int Wacht()
        {
            TimeSpan wachttijd = inputDate.Value - DateTime.Now;
            System.Threading.Thread.Sleep((int)wachttijd.TotalMinutes);
            return (int)wachttijd.TotalMilliseconds;
        }

        private void inputTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void OpslaanTaak_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (inputDate.Value > DateTime.Now)
                {

                    lijstvanObjecten.Add(new TeDoen(inputDate.Value, inputTitle.Text, textBox1.Lines));
                    lijstDatum.Add(inputDate.Value);
                    inputTitle.Text = null;
                    textBox1.Text = null;

                }
                else
                {
                    MessageBox.Show("! begin opnieuw");
                }
            }
            else
            {
                rij.InDeRij(new TeDoen(inputTitle.Text, textBox1.Lines));
                inputTitle.Text = null;
                textBox1.Text = null;

            }

            
            inputDate.Value = DateTime.Now;

        }
        public void StartTimer()
        {
            System.Timers.Timer Localtimer = new System.Timers.Timer(Wacht());
            Localtimer.Elapsed += label5_Tick;
            Localtimer.AutoReset = false;
            Localtimer.Start();
            LijstVanTimers.Add(Localtimer);
        }

        private void label5_Tick(object sender, EventArgs e)
        {
            foreach (DateTime date in lijstDatum)
            {
                if (date <= DateTime.Now)
                {
                    rij.WhenShow(lijstvanObjecten[lijstDatum.IndexOf(date)]);

                    lijstvanObjecten.RemoveAt(lijstDatum.IndexOf(date));
                    lijstDatum.RemoveAt(lijstDatum.IndexOf(date));

                }

            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                inputDate.Visible = true;
            }
            else
            {
                inputDate.Visible = false;
            }

        }

        private void volgendeTaak_Click(object sender, EventArgs e)
        {
            rij.Toon();
        }

        private void ZetAchteraan_Click(object sender, EventArgs e)
        {
            rij.ZetAchteraan();
        }

        private void verwijderTaak_Click(object sender, EventArgs e)
        {
            rij.UitDeRij();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "ON")
            {
                button1.Text = "OFF";
                button1.BackColor = Color.Red;
                inputInhoud.Text = null;
                rij.tonen -= new Tonen()
            }
            else
            {
                button1.Text = "ON";
                button1.BackColor = Color.Green;
                rij.tonen += new Tonen();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            {
                button2.Text = "OFF";
                button2.BackColor = Color.Red;
                rij.tonen -= new Tonen();
            }
            else
            {
                button2.Text = "ON";
                button2.BackColor = Color.Green;
                rij.tonen += new Tonen();
            }


        }
    }
    }

