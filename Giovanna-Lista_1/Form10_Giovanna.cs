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
    public partial class Form10_Giovanna : Form
    {
        public Form10_Giovanna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double l, a, c, v;
            try
            {

                c = Convert.ToDouble(textBox1.Text);
                a = Convert.ToDouble(textBox2.Text);
                l = Convert.ToDouble(textBox3.Text);

                v = c * l * a;

                label8.Text = v.ToString();
            }
            catch (FormatException) { 
                MessageBox.Show("Por favor digite um valor válido para todas as caixas de textos", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
            }
            
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Giovanna_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label8.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
