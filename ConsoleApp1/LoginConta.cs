using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LoginConta
    {
        public void LogadoNaConta(int numeroConta, int digito, int senha)
        {
            Console.WriteLine("CONTA BANCÁRIA");
            Console.WriteLine("---------------");

            Console.Write("Entre com o numero da conta: ");
            int numeroContaRecebido = int.Parse(Console.ReadLine());
            Console.Write("Entre com o digito da conta: ");
            int digitoRecebido = int.Parse(Console.ReadLine());
            Console.Write("Entre com a senha da conta: ");
            int senhaRecebida = int.Parse(Console.ReadLine());

            while (numeroContaRecebido != numeroConta || digitoRecebido != digito || senhaRecebida != senha)
            {
                Console.WriteLine("Informações invalidas, tente novamente...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("CONTA BANCÁRIA");
                Console.WriteLine("---------------");

                Console.Write("Entre com o numero da conta: ");
                numeroContaRecebido = int.Parse(Console.ReadLine());
                Console.Write("Entre com o digito da conta: ");
                digitoRecebido = int.Parse(Console.ReadLine());
                Console.Write("Entre com a senha da conta: ");
                senhaRecebida = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Login efetuado com sucesso, clique em qualquer tecla para continuar...");
            Console.ReadKey();
            EscolhaDaOperação escolhaDaOperação = new EscolhaDaOperação();
            Console.Clear();
            escolhaDaOperação.TipoDeOperação();
        }
    }
}
