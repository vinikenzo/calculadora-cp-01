using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        double valor1 = 0;
        double valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void numero0_Click(object sender, EventArgs e)
        {
            { mostrador.Text += "0"; }
        }

        private void numero1_Click(object sender, EventArgs e)
        {
            { mostrador.Text += "1"; }
        }

        private void numero2_Click(object sender, EventArgs e)
        {
            { mostrador.Text += "2"; }
        }

        private void numero3_Click(object sender, EventArgs e)
        {
            { mostrador.Text += "3"; }
        }

        private void numero4_Click(object sender, EventArgs e)
        {
            { mostrador.Text += "4"; }
        }

        private void numero5_Click(object sender, EventArgs e)
        {
            { mostrador.Text += "5"; }
        }

        private void numero6_Click(object sender, EventArgs e)
        {
            { mostrador.Text += "6"; }
        }

        private void numero7_Click(object sender, EventArgs e)
        {
            { mostrador.Text += "7"; }
        }

        private void numero8_Click(object sender, EventArgs e)
        {
            { mostrador.Text += "8"; }
        }

        private void numero9_Click(object sender, EventArgs e)
        {
            { mostrador.Text += "9"; }
        }

        private void potencia_Click(object sender, EventArgs e)
        {
            if (mostrador.Text != "")
            {
                valor1 = double.Parse(mostrador.Text);
                operacao = "^";
                mostrador.Clear();
            }
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            if (mostrador.Text != "")
            {
                valor1 = double.Parse(mostrador.Text);
                if (valor1 >= 0)
                {
                    double resultado = Math.Sqrt(valor1);
                    mostrador.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Não é possível calcular a raiz quadrada de número negativo.");
                    mostrador.Clear();
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            mostrador.Clear();
            valor1 = 0;
            valor2 = 0;
            operacao = "";
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            if (mostrador.Text != "")
            {
                valor1 = double.Parse(mostrador.Text);
                operacao = "/";
                mostrador.Clear();
            }
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            if (mostrador.Text != "")
            {
                valor1 = double.Parse(mostrador.Text);
                operacao = "x";
                mostrador.Clear();
            }
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            if (mostrador.Text != "")
            {
                valor1 = double.Parse(mostrador.Text);
                operacao = "-";
                mostrador.Clear();
            }
        }

        private void soma_Click(object sender, EventArgs e)
        {
            if (mostrador.Text != "")
            {
                valor1 = double.Parse(mostrador.Text);
                operacao = "+";
                mostrador.Clear();
            }
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            if (mostrador.Text == "") return;

            valor2 = double.Parse(mostrador.Text);
            double resultado = 0;

            if (operacao == "+") resultado = valor1 + valor2;
            else if (operacao == "-") resultado = valor1 - valor2;
            else if (operacao == "x") resultado = valor1 * valor2;
            else if (operacao == "/")
            {
                if (valor2 == 0)
                {
                    MessageBox.Show("Divisão por zero não permitida.");
                    mostrador.Clear();
                    return;
                }
                resultado = valor1 / valor2;
            }
            else if (operacao == "^") resultado = Math.Pow(valor1, valor2);

            mostrador.Text = resultado.ToString();
        }

        private void Sobre_Click(object sender, EventArgs e)
        {
            FormSobre formSobre = new FormSobre();
            formSobre.ShowDialog();
        }
    }
}
