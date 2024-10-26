namespace ConsoleApp1
{
    public class TelaInicial
    {
        private ContaBancaria contaBancaria;

        public void Inicio()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("CONTA BANCÁRIA");
                Console.WriteLine("---------------");
                Console.WriteLine("1 - Criar conta\n2 - Entrar na conta\n3 - Sair");
                Console.Write("Qual operação deseja realizar? ");
                int tipoDeConsulta = int.Parse(Console.ReadLine());

                while (tipoDeConsulta < 1 || tipoDeConsulta > 3)
                {
                    Console.WriteLine("Escolha inválida. Tente novamente...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("CONTA BANCÁRIA");
                    Console.WriteLine("---------------");
                    Console.WriteLine("1 - Criar conta\n2 - Entrar na conta\n3 - Sair");
                    tipoDeConsulta = int.Parse(Console.ReadLine());
                }

                switch (tipoDeConsulta)
                {
                    case 1:
                        Console.Clear();
                        CriarConta criarConta = new CriarConta();
                        contaBancaria = criarConta.CriandoConta();
                        break;
                    case 2:
                        Console.Clear();
                        if (contaBancaria != null)
                        {
                            LoginConta loginConta = new LoginConta();
                            loginConta.LogadoNaConta(contaBancaria);
                        }
                        else
                        {
                            Console.WriteLine("Nenhuma conta criada. Crie uma conta primeiro.");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Encerrando o programa...");
                        return;
                }
            }
        }
    }
}
