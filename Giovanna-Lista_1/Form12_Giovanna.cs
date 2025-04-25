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
    public partial class Form12_Giovanna : Form
    {
        double n1, n2, rs, rqs;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                rqs = rs * rs;
                label6.Text = rqs.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor digite um valor válido para todas as caixas de textos", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label6.Text = "";
            label8.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public Form12_Giovanna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                rs = n1 + n2;
                label8.Text = rs.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor digite um valor válido para todas as caixas de textos", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
