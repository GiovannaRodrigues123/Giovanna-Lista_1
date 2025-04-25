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
    public partial class Form16_Giovanna : Form
    {
        public Form16_Giovanna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            int n1, n2, quo, res;
            n1 = Convert.ToInt32(textBox1.Text);
            n2 = Convert.ToInt32(textBox2.Text);
                quo = n1 / n2;
                res = n1 % n2;
                label5.Text = quo.ToString();
                label6.Text = res.ToString();


            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor digite um valor válido para todas as caixas de textos", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "";
            label6.Text = "";
        }
    }
}
