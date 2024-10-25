using ConsoleApp1;
using System;
using System.Globalization;

namespace uri1143
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Inicio();

           

            //Console.Write("Entre com o número da conta: ");
            //int numero = int.Parse(Console.ReadLine());

            //while (numero.ToString().Length != 4) 
            //{
            //    Console.WriteLine("A conta precisa ter exatamente 4 digitos ");
            //    Console.ReadKey();
            //    Console.Clear();
            //    Console.Write("Entre com o número da conta: ");
            //    numero = int.Parse(Console.ReadLine());

            //}

            //Console.Write("Entre com o titular da conta: ");
            //string titular = Console.ReadLine();

            //while(titular == "")
            //{
            //    Console.WriteLine("Digite seu nome corretamente");
            //    Console.ReadKey();
            //    Console.Clear();
            //    Console.WriteLine($"Entre com o número da conta: {numero}");
            //    Console.Write("Entre com o titular da conta: ");
            //    titular = Console.ReadLine();

            //}

            //Console.Write("Haverá depósito inicial (s/n)? ");
            //char resp = char.ToUpper(char.Parse(Console.ReadLine())); // Converte para maiúsculo

            
            //while (resp != 'S' && resp != 'N')
            //{
            //    Console.WriteLine("Opção inválida. Por favor, insira 's' para sim ou 'n' para não.");
            //    Console.ReadKey();
            //    Console.Clear();
            //    Console.WriteLine($"Entre com o número da conta: {numero}");
            //    Console.WriteLine($"Entre com o titular da conta:  {titular}");
            //    Console.Write("Haverá depósito inicial (s/n)? ");
            //    resp = char.ToUpper(char.Parse(Console.ReadLine()));
            //    Console.WriteLine();
            //}

            ////if (resp == 'S')
            ////{
            ////    Console.Write("Digite o valor do depósito que será efetuado: ");
            ////    double depositoInicial = double.Parse(Console.ReadLine());

            ////    conta = new ContaBancaria(numero, digito, titular, depositoInicial);
            ////}
            ////else
            ////{
            ////    conta = new ContaBancaria(numero, digito, titular);
            ////}

            //Console.WriteLine("\nDados da conta");
            //Console.WriteLine("---------------");
            ////Console.WriteLine(conta);

            //Console.Write("\nEntre com um valor para deposito: ");
            //double quantia = double.Parse(Console.ReadLine());
            //Console.WriteLine("DADOS DA CONTA ATUALIZADOS:");
            ////conta.Deposito(quantia);
            ////Console.WriteLine(conta);

            //Console.Write("\nEntre com um valor para saque: ");
            //quantia = double.Parse(Console.ReadLine());
            
            ////while(quantia > conta.Saldo)
            ////{
            ////    Console.WriteLine("Seu saldo não é suficiente para efetuar esse saque");
            ////    Console.WriteLine($"Saldo da conta R${conta.Saldo}");
            ////    Console.Write("\nEntre com um valor para saque: ");
            ////    quantia = double.Parse(Console.ReadLine());
                

            ////}
            ////conta.Saque(quantia);

            ////Console.WriteLine("DADOS DA CONTA ATUALIZADOS:");
            ////Console.WriteLine(conta);
            ////Console.ReadKey();
        }
    }
}
