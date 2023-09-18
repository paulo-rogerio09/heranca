using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefaHeranca.Banco
{
    internal class ContaEstudante : ContaPai
    {
       

        public double LimiteChequeEspecial { get; set; }
        public string Cpf { get; set; }
        public string NomeInstituicao { get; set; }

       

        public ContaEstudante(double limiteChequeEspecial, string cpf, string nomeInstituicao, int numeroConta, string agencia, string titular, double saldo)
            :base(numeroConta, agencia, titular, saldo)
        {
            LimiteChequeEspecial = limiteChequeEspecial;
            Cpf = cpf;
            NomeInstituicao = nomeInstituicao;
            NumeroConta = numeroConta;
            Agencia = agencia;
            Titular = Titular;
            Saldo = Saldo;
        }
        public ContaEstudante()
        {

        }

        public override void Sacar(double valor)
        {
            double saldo = Saldo + LimiteChequeEspecial;
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                Saldo = Saldo - saldo;
                Console.WriteLine("Saque realizado");
                Console.WriteLine(Saldo);
            }
        }
    }
}
