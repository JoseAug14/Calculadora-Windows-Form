using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private operacao operacaoselecionada { get; set; }
        private decimal resultado { get; set; }
        private decimal valor { get; set; }
        private enum operacao
        {
            adicao,
            subtracao,
            multiplicacao,
            divisao,
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text +="3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            switch (operacaoselecionada) 
            {
                case operacao.adicao:
                    resultado = valor + Convert.ToDecimal(txtResultado.Text);
                    txtResultado.Text = resultado.ToString();
                    break;

                case operacao.subtracao:
                    resultado = valor - Convert.ToDecimal(txtResultado.Text);
                    txtResultado.Text = resultado.ToString();
                    break;

                case operacao.multiplicacao:
                    resultado = valor * Convert.ToDecimal(txtResultado.Text);
                    txtResultado.Text= resultado.ToString();
                    break;

                case operacao.divisao:
                    resultado = valor / Convert.ToDecimal(txtResultado.Text);
                    txtResultado.Text = resultado.ToString();
                    break;


            }
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            operacaoselecionada = operacao.adicao;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnsubtracao_Click(object sender, EventArgs e)
        {
            operacaoselecionada = operacao.subtracao;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnmultiplicacao_Click(object sender, EventArgs e)
        {
            operacaoselecionada = operacao.multiplicacao;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            operacaoselecionada = operacao.divisao;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }
    }
}
