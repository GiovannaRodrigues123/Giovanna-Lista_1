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
    public partial class Form8_Giovanna : Form
    {
        public Form8_Giovanna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double va, vb;
            try
            {
va = Convert.ToDouble(textBox1.Text);
            vb = Convert.ToDouble(textBox2.Text);

            label5.Text = vb.ToString();
            label6.Text = va.ToString();
         
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, digite um valor válido para o primeiro e segundo número.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            




        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label6.Text = "";
            label5.Text = "";
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
