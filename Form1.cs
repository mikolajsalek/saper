namespace saper


{
    public partial class Form1 : Form
    {
        int rozmiar, szukana;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string szukane_t = textBox1.Text;
            szukana = Int16.Parse(szukane_t);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string rozmiar_t = textBox2.Text;
            rozmiar = Int16.Parse(rozmiar_t);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 plansza = new Form2(rozmiar, szukana);
            plansza.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}