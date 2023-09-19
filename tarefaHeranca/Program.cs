using tarefaHeranca.Banco;
using tarefaHeranca.Banco;
using System;

public class Program
{
    static void Main(string[] args)
    {

        ContaPai c = new ContaPai();
        c.NumeroConta = 036;
        c.Agencia = "75744";
        c.Titular = "Paulo Rogerio";
        c.Saldo = 10000;

        

        while (true)
        {
        inicio:;
            Console.WriteLine("escolha a opção: \n1- conta empresarial\n" +
            "2- conta estudantil");
            int caso1 = Convert.ToInt32(Console.ReadLine());

            switch (caso1)
            {
                case 1:
                    ContaEmpresarial ce = new ContaEmpresarial();

                    ce.Anuidade = 5;
                    ce.LimiteEmprestimo = 10000;
                    ce.Saldo = 10000;
                reset:;
                    Console.WriteLine("escolha a opção: \n 1- fazer saque \n" +
            "2- fazer emprestimo\n" +
            "3- fazer deposito\n" +
            "4- voltar para o inicio");
                    int escolha1 = Convert.ToInt32(Console.ReadLine());

                   

                    if (escolha1 == 1)
                    {

                        //ContaEmpresarial contaEmpresarial = new ContaEmpresarial();

                        Console.WriteLine("Digite o valor para saque");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        ce.Sacar(valor);


                        //Console.WriteLine(c.Saldo);

                    }

                    else if (escolha1 == 2)
                    {
                        Console.WriteLine("digite o valor para fazer emprestimo");
                        double valorE = Convert.ToDouble(Console.ReadLine());
                        ce.Emprestimo(valorE);

                    }

                    else if (escolha1 == 3)
                    {
                        Console.WriteLine("digite o valor para fazer deposito");
                        double valorD = Convert.ToDouble(Console.ReadLine());
                        ce.Depositar(valorD);

                    }
                    else if (escolha1 == 4)
                    {
                        goto inicio;

                    }
                    goto reset;

                    break;

                case 2:

                    ContaEstudante ces = new ContaEstudante();
                    ces.LimiteChequeEspecial = 100;
                    ces.Saldo = 500;

                reset2:;

                    Console.WriteLine("escolha a sua opção:\n 1- fazer saque\n" +
                        "2- fazer deposito\n" +
                        "3- sair");
                    int escolha2 = Convert.ToInt32(Console.ReadLine());

                    if (escolha2 == 1)
                    {
                        Console.WriteLine("Digite o valor para saque");
                        double valorEs = Convert.ToDouble(Console.ReadLine());
                        ces.Sacar(valorEs);

                    }

                    else if (escolha2 == 2)
                    {
                        Console.WriteLine("digite o valor para fazer deposito");
                        double valorDes = Convert.ToDouble(Console.ReadLine());
                        ces.Depositar(valorDes);
                    }
                    else if (escolha2 == 3)
                    {
                        goto inicio;
                    }
                    goto reset2;

                    break;
            }
        }

        


    }

}
