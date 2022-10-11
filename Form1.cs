using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dB_konversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int operacao=0;
   
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 2;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 3;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            limparTela();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor_entrada, resultado;

            /*
             dB = 10*log10(P2/P1) (dB), 
            
            dBm= 10log(p1/.001)
            */

            try
            {
                valor_entrada = Double.Parse(txtValorAConverter.Text);

                if (operacao == 0)
                {
                    MessageBox.Show("Escolha uma grandeza.");
                }

                if (operacao == 1)
                {
                    //Converter em miliwatts
                    resultado = valor_entrada * 1000;
                    txtValorSaida.Text = resultado.ToString();
                }

                if (operacao == 2)
                {
                    //Converter em dB
                    resultado = 10 * (Math.Log(valor_entrada));

                    double teste = Math.Log10(valor_entrada);
                    txtValorSaida.Text = teste.ToString();
                    //txtValorSaida.Text = resultado.ToString();
                }

                if (operacao == 3)
                {
                    //Converter em dBm
                    resultado = 10 * (Math.Log10((valor_entrada) / 0.001));
                    txtValorSaida.Text = resultado.ToString();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
                MessageBox.Show("Inserir um número válido!","ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limparTela();
            }

        }

        private void btnVersao2_Click(object sender, EventArgs e)
        {
            conversor_v2 v2 = new conversor_v2();
            v2.Show();
        }

        private void limparTela()
        {
            //limpa a TextBox
            txtValorAConverter.Text = string.Empty; 
            txtValorSaida.Text = string.Empty;
        }
    }
}
