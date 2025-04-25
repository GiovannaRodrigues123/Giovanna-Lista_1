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
    public partial class Form2_Giovanna : Form
    {
        public Form2_Giovanna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double n1, n2, resultado;
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                resultado = n1 + n2;
                label5.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válidos no campo: Número 1 e número 2.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
