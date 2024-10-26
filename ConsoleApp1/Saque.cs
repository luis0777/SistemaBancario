using System;

namespace ConsoleApp1
{
    public class Saque
    {
        private ContaBancaria conta;

        // Construtor que recebe uma instância de ContaBancaria
        public Saque(ContaBancaria conta)
        {
            this.conta = conta;
        }

        public void Sacar()
        {
            Console.Clear();
            Console.WriteLine("CONTA BANCÁRIA");
            Console.WriteLine("---------------");
            Console.Write("Digite a quantia que deseja sacar: ");

            double quantia;
            // Loop para garantir que uma quantia válida seja inserida
            while (!double.TryParse(Console.ReadLine(), out quantia) || quantia <= 0)
            {
                Console.WriteLine("Valor inválido, tente novamente...");
                Console.Write("Digite a quantia que deseja sacar: ");
            }

            // Verifica se o saldo é suficiente
            if (conta.Saldo >= quantia)
            {
                conta.Saque(quantia);
                Console.WriteLine($"Saque de {quantia:C} realizado com sucesso!\nNovo saldo: {conta.Saldo:C}");
            }
            else
            {
                Console.WriteLine("\nSaldo insuficiente para realizar o saque.");
                Console.Write("Deseja efetuar o saque e ficar com saldo negativo? (s/n): ");
                char resposta = char.Parse(Console.ReadLine());

                if (resposta.ToString().ToLower() == "s")
                {
                    conta.Saque(quantia);
                    Console.WriteLine($"Saque de {quantia:C} realizado com sucesso! Novo saldo: {conta.Saldo:C}");
                }
                else
                {
                    Console.WriteLine("Saque cancelado.");
                }
            }
        }
    }
}
