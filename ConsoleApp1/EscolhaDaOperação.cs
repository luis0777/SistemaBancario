using System;

namespace ConsoleApp1
{
    public class EscolhaDaOperação
    {
        private ContaBancaria conta;

        // Construtor que recebe uma instância de ContaBancaria
        public EscolhaDaOperação(ContaBancaria conta)
        {
            this.conta = conta;
        }

        public void TipoDeOperação()
        {
            int tipoDeOperacao = 0;

            // Mantém o usuário no menu de operações até escolher sair
            do
            {
                Console.Clear();
                Console.WriteLine("CONTA BANCÁRIA");
                Console.WriteLine("---------------");
                Console.WriteLine("1 - Dados da conta\n2 - Depósito\n3 - Saque\n4 - Sair");
                Console.Write("Qual operação deseja realizar? ");

                tipoDeOperacao = int.Parse(Console.ReadLine());

                while (tipoDeOperacao < 1 || tipoDeOperacao > 4)
                {
                    Console.WriteLine("Operação inválida, tente novamente...");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("CONTA BANCÁRIA");
                    Console.WriteLine("---------------");
                    Console.WriteLine("1 - Dados da conta\n2 - Depósito\n3 - Saque\n4 - Sair");
                    Console.Write("Qual operação deseja realizar? ");
                    tipoDeOperacao = int.Parse(Console.ReadLine());
                }

                switch (tipoDeOperacao)
                {
                    case 1:
                        Console.Clear();
                        DadosAtualizados dadosAtualizados = new DadosAtualizados(conta);
                        dadosAtualizados.DadosDaConta();
                        break;
                    case 2:
                        Console.Clear();
                        Deposito deposito = new Deposito(conta);
                        deposito.Depositar();
                        break;
                    case 3:
                        Console.Clear();
                        Saque saque = new Saque(conta);
                        saque.Sacar();
                        break;
                    case 4:
                        Console.WriteLine("Saindo do menu de operações...");
                        break;
                }

                if (tipoDeOperacao != 4)
                {
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu de operações...");
                    Console.ReadKey();
                }

            } while (tipoDeOperacao != 4);
        }
    }
}
