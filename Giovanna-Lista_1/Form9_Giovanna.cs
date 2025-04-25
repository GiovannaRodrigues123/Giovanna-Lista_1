using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giovanna_Lista_1
{
    public partial class Form9_Giovanna : Form
    {
     double v1, v2, v3, v4;
        public Form9_Giovanna()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double r1, r2, r3, r4, r5, r6;
            try { 
            v1 = Convert.ToDouble(textBox1.Text);
            v2 = Convert.ToDouble(textBox2.Text);
            v3 = Convert.ToDouble(textBox3.Text);
            v4 = Convert.ToDouble(textBox4.Text);

            r1 = v1 * v2;
            r2 = v1 * v3;
            r3 = v1 * v4;
            r4 = v2 * v3;
            r5 = v2 * v4;
            r6 = v3 * v4;

            label30.Text = r1.ToString();
            label23.Text = r2.ToString();
            label24.Text = r3.ToString();
            label20.Text = r4.ToString();
            label21.Text = r5.ToString();
            label22.Text = r6.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, digite um valor válido para o primeiro, segundo, terceiro e quarto número.", "Erro",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form9_Giovanna_Load(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r1, r2, r3, r4, r5, r6;
            try { 
            v1 = Convert.ToDouble(textBox1.Text);
            v2 = Convert.ToDouble(textBox2.Text);
            v3 = Convert.ToDouble(textBox3.Text);
            v4 = Convert.ToDouble(textBox4.Text);

            r1  = v1 + v2;
            r2 = v1 + v3;
            r3 = v1+ v4;
            r4 = v2 + v3;
            r5 = v2 + v4;
            r6 = v3 + v4;

            label13.Text = r1.ToString();
            label15.Text = r2.ToString();
            label14.Text = r3.ToString();
            label18.Text = r4.ToString();
            label17.Text = r5.ToString();
            label16.Text = r6.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, digite um valor válido para o primeiro, segundo, terceiro e quarto número.", "Erro",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application
                .Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label20.Text = "";
            label21.Text = "";
            label22.Text = "";
            label23.Text = "";
            label24.Text = "";
            label30.Text = "";
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
