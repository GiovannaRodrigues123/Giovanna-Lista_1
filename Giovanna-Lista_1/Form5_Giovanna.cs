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
    public partial class Form5_Giovanna : Form
    {
        public Form5_Giovanna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double F, C;
            try { 
           
            F = Convert.ToDouble(textBox1.Text);
  
           
            C =  (F- 32) * (5 / 9);
                label4.Text = C.ToString("");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válidos no campo: Temperatura em fahrenheit.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label4.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
