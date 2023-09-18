using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefaHeranca.Banco
{
    internal class ContaPai
    {
        public int NumeroConta { get; set; }
        public string Agencia { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public ContaPai(int numeroConta, string agencia, string titular, double saldo)
        {
            this.NumeroConta = numeroConta;
            this.Agencia = agencia;
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public ContaPai()
        {
        }

        public virtual void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                double valorFinal = Saldo - valor;
                Console.WriteLine($"Saque efetuado com sucesso" +
                    $"\n foram sacados R${valor.ToString("F2")} para a sua conta. Valor total: R${valorFinal.ToString("F2")}.");
                Saldo = valorFinal;
            }

        }

        public void Depositar(double valor)
        {
            Saldo = Saldo + valor;
            Console.WriteLine("Valor total : R$" + Saldo);
        }
    }
}
