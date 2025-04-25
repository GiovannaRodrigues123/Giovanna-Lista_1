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
    public partial class Form13_Giovanna : Form
    {
        double n1, n2, rq1, rq2, rsq;

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                n2 = Convert.ToDouble(textBox2.Text);
                rq2 = n2 * n2;

                label6.Text = rq2.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor digite um valor válido para todas as caixas de textos", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                rsq = rq1 + rq2;


                label9.Text = rsq.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor digite um valor válido para todas as caixas de textos", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label8.Text = "";
            label6.Text = "";
            label9.Text = "";


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public Form13_Giovanna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToDouble(textBox1.Text);

                rq1 = n1 * n1;

                label8.Text = rq1.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor digite um valor válido para todas as caixas de textos", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
