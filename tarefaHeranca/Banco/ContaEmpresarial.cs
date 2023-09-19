using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefaHeranca.Banco
{

    internal class ContaEmpresarial : ContaPai
    {
        public double Anuidade { get; set; }
        public double LimiteEmprestimo { get; set; }
        public double TotalEmprestimo { get; set; }

        public ContaEmpresarial(double anuidade, double limiteEmprestimo, double totalEmprestimo, int numeroConta, string agencia, string titular, double saldo)
            :base(numeroConta, agencia, titular, saldo)

        {
            Anuidade = anuidade;
            LimiteEmprestimo = limiteEmprestimo;
            TotalEmprestimo = totalEmprestimo;
            NumeroConta = numeroConta;
            Agencia = agencia;
            Titular = titular;
            Saldo = saldo;
           

        }

        public ContaEmpresarial()
        {
        }

        public override void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente ");
            }
            else
            {
                if (valor >= 5000)
                {
                    valor = valor + 5;
                    Saldo = Saldo - valor;
                    Console.WriteLine("Saque realizado, Taxa cobrada: R$5,00");
                }
                else
                {

                    //double valorFinal = Saldo - valor;
                    Saldo = Saldo - valor;
                    Console.WriteLine($"Saque efetuado com sucesso" +
                        $"\n foram sacados R${valor.ToString("F2")} para a sua conta. Valor total: R${Saldo.ToString("F2")}.");
                   /* Saldo = valorFinal;*/

                   /* Saldo = Saldo - valor;
                     Console.WriteLine(Saldo);*/
                }
            }
        }



        public void Emprestimo(double valor)
        {
            if (valor > LimiteEmprestimo)
            {
                Console.WriteLine("Limite de empréstimo alcançado");
            }

            else
            {
                TotalEmprestimo = LimiteEmprestimo - valor;
                Saldo = Saldo - valor;
                Console.WriteLine($"Empréstimo realizado com sucesso" +
                    $"\nVocê tem R$ {TotalEmprestimo.ToString("F2")} de limite");
            }

            
        }

       
    }
}
