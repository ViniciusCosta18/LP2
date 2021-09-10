using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pcalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float valor1, valor2, resultado;

            valor1 = Convert.ToInt16(txtNum1.Text);
            valor2 = Convert.ToInt16(txtNum2.Text);

            resultado = valor1 / valor2;

            txtresult.Text = Convert.ToString(resultado);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt16(txtNum1.Text);
            valor2 = Convert.ToInt16(txtNum2.Text);

            resultado = valor1 + valor2;

            txtresult.Text = Convert.ToString(resultado);
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt16(txtNum1.Text);
            valor2 = Convert.ToInt16(txtNum2.Text);

            resultado = valor1 - valor2;

            txtresult.Text = Convert.ToString(resultado);
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt16(txtNum1.Text);
            valor2 = Convert.ToInt16(txtNum2.Text);

            resultado = valor1 * valor2;

            txtresult.Text = Convert.ToString(resultado);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtresult.Clear();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
