using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saper
{
    public partial class Form2 : Form
    {

        private int rozmiar;
        public int szukana;
        private int[] wybrany;
        private int licznik = 0;
        public int Counter = 0;

        public Form2(int rozmiar, int szukana)
        {
            this.rozmiar = rozmiar;
            this.szukana = szukana;
            InitializeComponent();
        }

        private void OnSizeChanged(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(rozmiar*50, rozmiar*50);
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(rozmiar * 50 + 100, rozmiar * 50);
            Counter = szukana * 3;
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            label1.Text = Counter.ToString();


            Random rnd = new Random();
            Button[] pola = new Button[rozmiar * rozmiar];

            wybrany = new int[szukana];

            int szukany = 0;

            for (int i = 0; i < rozmiar; i++)
            {
                for (int j = 0; j < rozmiar; j++, szukany++)
                {
                    pola[szukany] = new Button();
                    pola[szukany].Location = new Point(j * 50, i * 50);
                    pola[szukany].Size = new Size(50, 50);
                    pola[szukany].BackColor = System.Drawing.SystemColors.Highlight;
                    pola[szukany].TabIndex = szukany;

                    pola[szukany].Click += Button_Click;
                    this.Controls.Add(pola[szukany]);

                }


            }

            int[] wszystkie = new int[rozmiar * rozmiar];

            for (int i = 0; i < rozmiar * rozmiar; i++)
            {
                wszystkie[i] = i;
            }

            wszystkie = wszystkie.OrderBy(x => rnd.Next()).ToArray();

            for (int i = 0; i < szukana; i++)
            {
                wybrany[i] = wszystkie[i];

            }

            textBox1.Location = new Point(rozmiar * 50);
            label1.Location = new Point(rozmiar * 50,50);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;


            // Change the BackColor of the clicked button


            if (Array.Exists(wybrany, element => element == button.TabIndex))
            {
                button.BackColor = Color.Red;
                button.Enabled = false;
                licznik++;

            }

            if (licznik == szukana)
            {
                MessageBox.Show("WYGRANA!!!");

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter--;

            if (Counter == 0)
            {
                timer1.Stop();
                MessageBox.Show("Przegrales");
                this.Close();
            }
            label1.Text = Counter.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }
    }
}
