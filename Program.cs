using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Funcoes
            // soma de matriz

            var funcoes = new Funcoes();
            var soma = funcoes.Soma(new int[] { 1, 2, 3, 4 });
            var maior = funcoes.Maior(1, 2, 3, 100);

            Console.WriteLine("A soma dos números digitados é: " + soma.ToString());
            Console.WriteLine("O maior número digitado foi: " + maior.ToString());

            // Cadastros

            var conexao = new object();

            Console.ReadKey();

        }

       
    }
}
