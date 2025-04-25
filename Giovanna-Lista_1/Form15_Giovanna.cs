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
    public partial class Form15_Giovanna : Form
    {
        double v1, conversor;
        public Form15_Giovanna()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label8.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            v1 = Convert.ToDouble(textBox1.Text);
            conversor = v1/3.6;
            label8.Text = conversor.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor digite um valor válido para todas as caixas de textos", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
