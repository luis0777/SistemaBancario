namespace ConsoleApp1
{
    public class CriarConta
    {
        public ContaBancaria CriandoConta()
        {
            Console.WriteLine("CONTA BANCÁRIA");
            Console.WriteLine("---------------");

            Console.Write("Entre com o nome do titular da conta: ");
            string titular = Console.ReadLine();

            while (string.IsNullOrEmpty(titular))
            {
                Console.WriteLine("Nome inválido. Digite o nome do titular corretamente.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("CONTA BANCÁRIA");
                Console.WriteLine("---------------");
                Console.Write("Entre com o titular da conta: ");
                titular = Console.ReadLine();
            }

            Random random = new Random();
            int numeroDaConta = random.Next(10000, 100000);
            Console.WriteLine($"O número da conta é: {numeroDaConta}");

            int digitoDaConta = random.Next(1, 9);
            Console.WriteLine($"O dígito da conta é: {digitoDaConta}");

            Console.Write("Crie uma senha de 6 dígitos: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha.ToString().Length != 6)
            {
                Console.WriteLine("A senha deve conter exatamente 6 dígitos. Tente novamente...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("CONTA BANCÁRIA");
                Console.WriteLine("---------------");
                Console.WriteLine($"Titular: {titular}");
                Console.WriteLine($"Número da conta: {numeroDaConta}");
                Console.WriteLine($"Dígito da conta: {digitoDaConta}");
                Console.Write("Crie uma senha de 6 dígitos: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("CONTA CRIADA COM SUCESSO!!!");
            Console.WriteLine("Clique em qualquer tecla para continuar...");
            Console.ReadKey();

            return new ContaBancaria(numeroDaConta, digitoDaConta, senha, titular);
        }
    }
}
