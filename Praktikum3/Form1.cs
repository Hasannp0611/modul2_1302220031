using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonsatu(object sender, EventArgs e)
        {
            int satu = 1;
            label1.Text = label1.Text + satu;
        }

        private void buttondua(object sender, EventArgs e)
        {
            int dua = 2;
            label1.Text = label1.Text + dua;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int tiga = 3;
            label1.Text = label1.Text + tiga;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int empat = 4;
            label1.Text = label1.Text + empat;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int lima = 5;
            label1.Text = label1.Text + lima;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int enam = 6;
            label1.Text = label1.Text + enam;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int tujuh = 7;
            label1.Text = label1.Text + tujuh;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int delapan = 8;
            label1.Text = label1.Text + delapan;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int sembilan = 9;
            label1.Text = label1.Text + sembilan;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int nol = 0;
            label1.Text = label1.Text + nol;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int angka1;
        int angka2;
        private void button21_Click(object sender, EventArgs e)
        {
            angka1 = Int32.Parse(label1.Text);
            label1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            angka2 = Int32.Parse(label1.Text);
            angka1 = angka1 + angka2;
            label1.Text = "" + angka1;
        }
    }
}
