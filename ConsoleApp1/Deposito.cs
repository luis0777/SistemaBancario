using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    public class Deposito
    {
        private ContaBancaria conta;

        // Construtor que recebe uma instância de ContaBancaria
        public Deposito(ContaBancaria conta)
        {
            this.conta = conta;
        }
        public void Depositar()
        {
            Console.WriteLine("CONTA BANCÁRIA");
            Console.WriteLine("---------------");
            Console.Write("Digite a quantia que deseja depositar: ");
            double quantia = double.Parse(Console.ReadLine());
            while (quantia < 0)
            {
                Console.WriteLine("Valor invalido tente novamente...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("CONTA BANCÁRIA");
                Console.WriteLine("---------------");
                Console.Write("Digite a quantia que deseja depositar: ");
                quantia = double.Parse(Console.ReadLine());


            }
            conta.Deposito(quantia);
            Console.WriteLine($"Valor de R$ {quantia} depositado com sucesso.");
        }
    }
}
