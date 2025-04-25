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
    public partial class Form18_Giovanna : Form
    {
        public Form18_Giovanna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int d, m, a, troca;
            try { 
            d= Convert.ToInt32(textBox1.Text);
            m = Convert.ToInt32(textBox3.Text);
            a = Convert.ToInt32(textBox2.Text);
            troca = (a* 10000) + (m * 100) + d;
            label8.Text=troca.ToString();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label8.Text = "";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Form18_Giovanna_Load(object sender, EventArgs e)
        {

        }
    }
}
