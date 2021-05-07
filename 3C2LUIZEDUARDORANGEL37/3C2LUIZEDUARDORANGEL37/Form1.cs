using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3C2LUIZEDUARDORANGEL37
{
    public partial class Form1 : Form
    {
        double valorSaqueFinal = 0;
        int cont = 0;
        public Form1()
        {
            InitializeComponent();

        }

        ContaBancaria objconta = new ContaBancaria();


        private void btn_form_calculo_Click(object sender, EventArgs e)
        {
            if (txt_operacoes.Text != "")
            {
                if (rdb_sacar.Checked == true)
                {
                    double valorSaldo = double.Parse(txt_operacoes.Text);
                    valorSaqueFinal += valorSaldo;

                    if (valorSaqueFinal <= 500)
                    {
                        txt_resultado.Text = objconta.Sacar(valorSaldo).ToString("C");
                    }
                    else
                    {
                        if (cont >= 1)
                        {
                            MessageBox.Show(" Limite de R$ 500,00 por saldo diário atingido ...");
                        }
                        else
                        {
                            MessageBox.Show(" O valor de saque excedeu R$ 500,00 por isso foi sacado o valor mínimo do saldo");
                            txt_resultado.Text = objconta.Sacar(valorSaldo).ToString("C");
                            cont++;
                        }                        
                    }
                }
                else if (rdb_depositar.Checked == true)
                {
                    double valorSaldo = double.Parse(txt_operacoes.Text);

                    txt_resultado.Text = objconta.Depositar(valorSaldo).ToString("C");
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo corretamente!");
            }
            

        }
        private void btn_calcular_investimento_Click(object sender, EventArgs e)
        {
            if (txt_valor_investido.Text != "" && txt_valor_investido.Text != "0")
            {
                if (txt_juros.Text != "" && txt_juros.Text != "0")
                {
                    if (txt_tempo_investido.Text != "" && txt_tempo_investido.Text != "0")
                    {
                        double valor_investido = double.Parse(txt_valor_investido.Text);
                        double taxa_juros = double.Parse(txt_juros.Text);
                        double tempo_investido = double.Parse(txt_tempo_investido.Text);

                        MessageBox.Show("O valor final do seu investimento é de: " + objconta.Investir(valor_investido, taxa_juros, tempo_investido).ToString("C"));
                        txt_valor_investido.Text = "";
                        txt_juros.Text = "";
                        txt_tempo_investido.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Preencha o campo corretamente!");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente!");
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente!");
            }
            
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (txt_nome_titular.Text != "" && txt_nome_titular.Text != "0")
            {
                if (txt_nmr_conta.Text != "" && txt_nmr_conta.Text != "0")
                {
                    if (txt_agencia.Text != "" && txt_agencia.Text != "0")
                    {
                        if (txt_endereco.Text != "" && txt_endereco.Text != "0")
                        {
                            if (txt_telefone.Text != "" && txt_telefone.Text != "0")
                            {
                                if (txt_saldo.Text != "" && txt_saldo.Text != "0")
                                {
                                    InserirContas();
                                    grp_operacoes.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("Preencha os dados corretamente");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Preencha os dados corretamente");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Preencha os dados corretamente");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Preencha os dados corretamente");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os dados corretamente");
                }
            }
            else
            {
                MessageBox.Show("Preencha os dados corretamente");
            }

        }


        private void rdb_investir_CheckedChanged(object sender, EventArgs e)
        {
            grp_investimento.Visible = true;
            txt_operacoes.Enabled = false;
        }

        private void rdb_depositar_CheckedChanged(object sender, EventArgs e)
        {
            grp_investimento.Visible = false;
            txt_operacoes.Enabled = true;
        }

        private void rdb_sacar_CheckedChanged(object sender, EventArgs e)
        {
            grp_investimento.Visible = false;
            txt_operacoes.Enabled = true;
        }

        private void txt_tempo_investido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero e virgula");
            }
        }

        private void txt_operacoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero e virgula");
            }
        }

        private void txt_juros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero e virgula");
            }
        }

        private void txt_valor_investido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero e virgula");
            }
        }
        private void InserirContas()
        {

            string entradaNome = txt_nome_titular.Text;
            int nmrConta = int.Parse(txt_nmr_conta.Text);
            int nmrAgencia = int.Parse(txt_agencia.Text);
            string endereco = txt_endereco.Text;
            string telefone = txt_telefone.Text;
            double saldo = double.Parse(txt_saldo.Text);

            objconta.Conta(nome: entradaNome, nmrconta: nmrConta, nmragencia: nmrAgencia, endereco: endereco, saldo: saldo, telefone: telefone);
        }
        
    }
}
