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
    public partial class Form1 : Form
    { double pi = 3.14159, area, raio;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label3.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                raio = Convert.ToDouble(textBox1.Text);
                area = pi * raio * 2;
                label3.Text = area.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válidos no campo: raio da circunferência.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
