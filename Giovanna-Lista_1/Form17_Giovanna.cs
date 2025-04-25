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
    public partial class Form17_Giovanna : Form
    {
        public Form17_Giovanna()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form17_Giovanna_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sl, sb;
            try { 
            sb = Convert.ToDouble(textBox1.Text);
            sl = sb-(sb * 10 / 100);
            sl = sl - (sl * 5 / 100);
            label10.Text=sl.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor digite um valor válido para todas as caixas de textos", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label10.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application
                .Exit();
        }
    }
}
