using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iksoks
{
    public partial class Form1 : Form
    {
        bool potez = false;
        int count = 0;
        public void Provera()
        {
            if ((a1.Text == a2.Text && a2.Text == a3.Text && a1.Enabled == false)|| (b1.Text==b2.Text && b2.Text==b3.Text&& b1.Enabled == false) || (c1.Text == c2.Text && c2.Text == c3.Text&& c1.Enabled == false))
                Pobeda();
            if ((a1.Text==b1.Text && b1.Text==c1.Text && a1.Enabled==false) || (a2.Text == b2.Text && b2.Text == c2.Text && a2.Enabled == false) || (a3.Text == b3.Text && b3.Text == c3.Text && a3.Enabled == false))
            Pobeda(); 
            if ((a1.Text == b2.Text && b2.Text == c3.Text && a1.Enabled == false) || (a3.Text == b2.Text && b2.Text == c1.Text && a3.Enabled == false))
            Pobeda();
            if (count == 9)
            {
                MessageBox.Show("NERESENO");
                Reset();
                
            }
        }
        public void Reset()
        {
            a1.Enabled = a2.Enabled = a3.Enabled = b1.Enabled = b2.Enabled = b3.Enabled = c1.Enabled = c2.Enabled = c3.Enabled = true;
            a1.Text = a2.Text = a3.Text = b1.Text = b2.Text = b3.Text = c1.Text = c2.Text = c3.Text = "";
            count = 0;
        }
        public void Pobeda()
        {
            MessageBox.Show(potez ? "Pobednik je X" : "Pobednik je O");
            potez = !potez;
            Reset();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void novaIgraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void izadjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button dugme = (Button)sender;
            if (dugme.Enabled == true)
            {
                dugme.Enabled = false;
                dugme.Text = potez ? "O" : "X";
                
                potez = !potez;
                count++;               
                Provera();
                label1.Text = potez ? "IGRAC O JE NA POTEZU" : "IGRAC X JE NA POTEZU";

            }



        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("IKS OKS\nNapravljeno iz dosade\nNovembar 2022.\nDimitrije Sovljanski");
        }

        private void kakoSeIgraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                MessageBox.Show("?XD");
            }
        }
    }
}
