namespace ConsoleApp1
{
    public class LoginConta
    {
        public void LogadoNaConta(ContaBancaria conta)
        {
            Console.WriteLine("CONTA BANCÁRIA");
            Console.WriteLine("---------------");

            Console.Write("Entre com o número da conta: ");
            int numeroContaRecebido = int.Parse(Console.ReadLine());
            Console.Write("Entre com o dígito da conta: ");
            int digitoRecebido = int.Parse(Console.ReadLine());
            Console.Write("Entre com a senha da conta: ");
            int senhaRecebida = int.Parse(Console.ReadLine());

            while (numeroContaRecebido != conta.Numero || digitoRecebido != conta.Digito || senhaRecebida != conta.Senha)
            {
                Console.WriteLine("Informações inválidas, tente novamente...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("CONTA BANCÁRIA");
                Console.WriteLine("---------------");
                Console.Write("Entre com o número da conta: ");
                numeroContaRecebido = int.Parse(Console.ReadLine());
                Console.Write("Entre com o dígito da conta: ");
                digitoRecebido = int.Parse(Console.ReadLine());
                Console.Write("Entre com a senha da conta: ");
                senhaRecebida = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Login efetuado com sucesso, clique em qualquer tecla para continuar...");
            Console.ReadKey();

            EscolhaDaOperação escolhaDaOperação = new EscolhaDaOperação(conta);
            Console.Clear();
            escolhaDaOperação.TipoDeOperação();
        }
    }
}
