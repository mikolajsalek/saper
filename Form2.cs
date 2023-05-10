using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private int szukana;
        private int[] wybrany;
        private int licznik = 0;

        public Form2(int rozmiar, int szukana)
        {
            this.rozmiar = rozmiar;
            this.szukana = szukana;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Button[] pola = new Button[rozmiar*rozmiar];

            wybrany = new int[szukana];

            int szukany = 0;

            for (int i = 0; i < rozmiar; i++)
            {
                for (int j = 0; j < rozmiar; j++, szukany++)
                {
                    pola[szukany] = new Button();
                    pola[szukany].Location = new Point(j*50, i * 50);
                    pola[szukany].Size = new Size(50, 50);
                    pola[szukany].BackColor = System.Drawing.SystemColors.Highlight;
                    pola[szukany].TabIndex = szukany;
                    
                    pola[szukany].Click += Button_Click;
                    this.Controls.Add(pola[szukany]);

                }
               
                
            }

            int[] wszystkie = new int[rozmiar*rozmiar];

            for (int i = 0; i < rozmiar * rozmiar; i++)
            {
                wszystkie[i] = i;
            }

            wszystkie = wszystkie.OrderBy(x => rnd.Next()).ToArray();

            for (int i = 0; i < szukana; i++)
            {
                wybrany[i] = wszystkie[i];
                
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            

            // Change the BackColor of the clicked button


            if(Array.Exists(wybrany, element => element == button.TabIndex))
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

    }
}
