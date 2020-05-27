using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triângulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.msg = triangulo.Verificar(txbLadoA.Text, txbLadoB.Text, txbLadoC.Text);
            MessageBox.Show("O triângulo é "+ triangulo.msg);
            txbLadoA.Text = "";
            txbLadoB.Text = "";
            txbLadoC.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
