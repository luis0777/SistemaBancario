using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EscolhaDaOperação
    {
        ContaBancaria conta;
        public void TipoDeOperação()
        {
            Console.WriteLine("CONTA BANCÁRIA");
            Console.WriteLine("---------------");
            Console.WriteLine("1 - Dados da conta\n2 - Deposito\n3 - Saque");
            Console.Write("Qual operação deseja realizar? ");

            int tipoDeOperação = int.Parse(Console.ReadLine());

            while (tipoDeOperação != 1 && tipoDeOperação != 2 && tipoDeOperação != 3)
            {
                Console.WriteLine("Operação invalida, tente novamente...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("CONTA BANCÁRIA");
                Console.WriteLine("---------------");
                Console.WriteLine("1 - Dados da conta\n2 - Deposito\n3 - Saque");
                Console.Write("Qual operação deseja realizar? "); ;
                tipoDeOperação = int.Parse(Console.ReadLine());
            }

            switch (tipoDeOperação)
            {
                case 1:
                    Console.WriteLine(conta);
                    break;
                case 2:

                    break;
                case 3:
                    break;

            }
        }
    }
}
