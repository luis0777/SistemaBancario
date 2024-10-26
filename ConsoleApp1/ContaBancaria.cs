
namespace ConsoleApp1
{
    public class ContaBancaria
    {
        public int Numero { get; private set; }
        public int Digito {  get; private set; }
        public int Senha { get; private set; }
        public string Titular  { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, int digito, int senha, string titular)
        {
            Numero = numero;
            Digito = digito;
            Senha = senha;
            Titular = titular;
        }

        public ContaBancaria(int numero, int digito, int senha, string titular, double deposito) : this (numero , digito, senha, titular) 
        {
            Deposito(deposito);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= (quantia + 5.0);
        }

        public override string ToString()
        {
            return $"Conta {Numero}-{Digito}\nTitular: {Titular}\nSaldo: R$ {Saldo.ToString("F2")} ";
        }


    }
}