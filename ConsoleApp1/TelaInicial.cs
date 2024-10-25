using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class TelaInicial
    {
        private CriarConta criarConta;
        public void Inicio()
        {
            Console.WriteLine("CONTA BANCÁRIA");
            Console.WriteLine("---------------");
            Console.WriteLine("1 - Criar conta\n2 - Entrar na conta");
            Console.Write("Qual operação deseja realizar? ");
            int tipoDeConsulta = int.Parse(Console.ReadLine());

            while (tipoDeConsulta != 1 && tipoDeConsulta != 2)
            {
                Console.WriteLine("Escolha invalida tente novamente...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("CONTA BANCÁRIA");
                Console.WriteLine("---------------");
                Console.WriteLine("1 - Criar conta\n2 - Entrar na conta");
                tipoDeConsulta = int.Parse(Console.ReadLine());

            }

            

            switch (tipoDeConsulta)
            {
                case 1:
                    Console.Clear();
                    criarConta = new CriarConta();
                    criarConta.CriandoConta();
                    break;
                case 2:
                    if (criarConta != null)
                    {
                        LoginConta loginConta = new LoginConta();
                        int numero = criarConta.numeroDaConta;
                        int digito = criarConta.digitoDaConta;
                        int senha = criarConta.senha;
                        loginConta.LogadoNaConta(numero, digito, senha);
                    }
                    else
                    {
                        Console.WriteLine("Crie a conta primeiro");
                        Console.ReadKey(true);
                    }
                    break;
            }

        }
    }
}
