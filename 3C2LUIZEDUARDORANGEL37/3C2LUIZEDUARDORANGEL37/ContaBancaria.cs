using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C2LUIZEDUARDORANGEL37
{
    public class ContaBancaria
    {

        private string Nome
        {
            get; set;
        }
        private int NmrConta
        {
            get; set;
        }
        private int NmrAgencia
        {
            get; set;
        }
        private string Endereco
        {
            get; set;
        }
        private double Saldo
        {
            get; set;
        }
        private string Telefone
        {
            get; set;
        }
        
        public void Conta(string nome, int nmrconta, int nmragencia, string endereco, double saldo, string telefone)
        {            
            this.Nome = nome;
            this.NmrConta = nmrconta;
            this.NmrAgencia = nmragencia;
            this.Endereco = endereco;
            this.Saldo = saldo;
            this.Telefone = telefone;
        }

        public double Sacar(double v1)
        {
            if (v1 <= 500)
            {
                double c2 = 0;
                double c1 = this.Saldo -= v1;
                c2 = c2 + c1;
                return c2;
            }
            else
            {
                double c1 = this.Saldo -= 500;
                return c1;
            }
            
        }
        public double Depositar(double v1)
        {           
            return this.Saldo += v1;
        }
        public double Investir(double valor, double taxaJuros, double tempo)
        {
            int i = 0;
            double c1 = 0;
            double c2 = 0;

            while (i < tempo)
            {
                c1 = (taxaJuros / 100) * valor;
                Math.Round(c1, 2);
                c2 = valor += c1;
                Math.Round(c2, 2);
                i++;
            }
            return c2; 
        }
    }
}
