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
    public partial class Form6_Giovanna : Form
    {
        public Form6_Giovanna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vol, r, al,pi = 3.14159;
            try
            {
                r = Convert.ToDouble(textBox1.Text);
                al = Convert.ToDouble(textBox2.Text);

                vol = pi * (r * r) * al;
                label5.Text = vol.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, digite um valor válido para o raio e altura da área.", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Giovanna_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "";

        }
    }
}
