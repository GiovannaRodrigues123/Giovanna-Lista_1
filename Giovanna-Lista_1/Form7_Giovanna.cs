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
    public partial class Form7_Giovanna : Form
    {
        public Form7_Giovanna()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dt, lt_usa, vm, tg;
            try
            {
tg = Convert.ToDouble(textBox1.Text);
            vm= Convert.ToDouble(textBox2.Text);
            dt = tg * vm;
            lt_usa = dt / 12;

            label8.Text = vm.ToString();
            label11.Text = lt_usa.ToString();
            label12.Text = tg.ToString();
            label13.Text = dt.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Por favor, digite um valor válido para o tempo gasto na viagem e velocidade média.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear  ();
            textBox2.Clear ();
            label8.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";

        }
    }
}
