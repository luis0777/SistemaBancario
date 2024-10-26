using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DadosAtualizados
    {
        private ContaBancaria conta;
        // Construtor que recebe uma instância de ContaBancaria
        public DadosAtualizados(ContaBancaria conta)
        {
            this.conta = conta;
        }

        public void DadosDaConta()
        {
            Console.WriteLine("CONTA BANCÁRIA");
            Console.WriteLine("---------------");
            Console.WriteLine(conta);
        }
    }
}
