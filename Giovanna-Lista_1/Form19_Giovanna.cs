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
    public partial class Form19_Giovanna : Form
    {
        public Form19_Giovanna()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ano, semestre, ordem, anoCompleto;
                string resultado;
               
                 ano = Convert.ToInt32(textBox1.Text);
                semestre = Convert.ToInt32(textBox3.Text);
                 ordem = Convert.ToInt32(textBox2.Text);

             
                 anoCompleto = 2000 + ano;

                
                 resultado = "Ano da matrícula: " +anoCompleto+"\nSemestre: "+semestre+"º" ;
                label8.Text = resultado.ToString();
            }
            catch
            {
                MessageBox.Show("Preencha todos os campos corretamente.");
            }
        }
    }
}
