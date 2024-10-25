using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CriarConta
    {
        public int numeroDaConta { get; private set; }
        public int digitoDaConta { get; private set; }
        public int senha { get; private set; }
        public void CriandoConta()
        {
            Console.WriteLine("CONTA BANCÁRIA");
            Console.WriteLine("---------------");

            Console.Write("Entre com o nome da pessoa que será titular da conta: ");
            string titular = Console.ReadLine();

            while (titular == "")
            {
                Console.WriteLine("Digite seu nome corretamente");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("CONTA BANCÁRIA");
                Console.WriteLine("---------------");
                Console.Write("Entre com o titular da conta: ");
                titular = Console.ReadLine();

            }

            Random random = new Random();
            int numeroDaConta = random.Next(10000, 100000);

            Console.WriteLine($"O número da conta da sua conta é: {numeroDaConta}");
  

            int digitoDaConta = random.Next(1, 9);
            Console.WriteLine($"O digito da conta é: {digitoDaConta}");


            Console.Write("Crie uma senha de 6 digitos: ");
            int senha = int.Parse( Console.ReadLine() );

            while( senha.ToString().Length != 6 )
            {
                Console.WriteLine("A senha deve conter exatamente 6 digitos, tente novamente...");
                Console.ReadKey();
                Console.Clear() ;
                Console.WriteLine("CONTA BANCÁRIA");
                Console.WriteLine("---------------");
                Console.WriteLine($"Entre com o titular da conta: {titular}");
                Console.WriteLine($"O número da conta da sua conta é: {numeroDaConta}");
                Console.WriteLine($"O digito da conta é: {digitoDaConta}");
                Console.Write("Crie uma senha de 6 digitos: ");
                senha = int.Parse(Console.ReadLine());
            }

            this.numeroDaConta = numeroDaConta;
            this.digitoDaConta = digitoDaConta;
            this.senha = senha;

            Console.WriteLine("CONTA CRIADA COM SUCESSO!!!");
            Console.WriteLine("Clique em qualquer tecla para continuar...");
            Console.ReadKey();

            //TelaInicial telaInicial = new TelaInicial();
            //Console.Clear();
            //telaInicial.Inicio();
            LoginConta loginconta = new LoginConta();
            Console.Clear();
            loginconta.LogadoNaConta(numeroDaConta, digitoDaConta, senha);
        }
    }
}
