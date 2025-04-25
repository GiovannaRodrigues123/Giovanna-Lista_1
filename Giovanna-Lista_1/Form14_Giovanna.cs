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
    public partial class Form14_Giovanna : Form
    { double v1, v2, md;
        public Form14_Giovanna()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            label8.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            v1 = Convert.ToDouble(textBox1.Text);
            v2 = Convert.ToDouble(textBox3.Text);
            md = (v1 + v2) / 2;
            label8.Text = md.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor digite um valor válido para todas as caixas de textos", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application
                .Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
