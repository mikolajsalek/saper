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

        public Form2(int rozmiar, int szukana)
        {
            this.rozmiar = rozmiar;
            this.szukana = szukana;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Button[] pola = new Button[rozmiar];

            for (int i = 0; i < rozmiar*rozmiar; i++)
            {
                pola[i] = new Button();
                pola[i].Location = new Point(i*50);
                pola[i].Size = new Size(50, 50);
                pola[i].BackColor = System.Drawing.SystemColors.Highlight;
                //pola[i].TabIndex = i;
                //pola[i].Text = "Button " + (i + 1);
                this.Controls.Add(pola[i]);
                
            }
        }
    }
}
