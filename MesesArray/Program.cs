using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesesArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] meses = { "Esse mês não existe. Digite outro número.", "Janeiro", "fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

            Console.WriteLine("Digite o número do mês que você escolheu: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("O mês escolhido foi: "+ meses[n]);

            Console.ReadKey();
        }
    }
}
