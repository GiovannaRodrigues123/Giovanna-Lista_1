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
    public partial class Form11_Giovanna : Form
    {
        double v1;
        public Form11_Giovanna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Q;
            try
            {
                v1 = Convert.ToDouble(textBox1.Text);
                Q = v1 * v1;
                label8.Text = Q.ToString();
            }
            catch (FormatException) {
                MessageBox.Show("Por favor digite um valor válido para todas as caixas de textos", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double C;
            try
            {
                v1 = Convert.ToDouble(textBox1.Text);
                C = v1 * v1 * v1;
                label6.Text = C.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor digite um valor válido para todas as caixas de textos", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            label8.Text = "";
            textBox1.Clear();
          

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
