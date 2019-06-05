using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquivoTextoFormatado
{
    class Program
    {
        static void Main(string[] args)
        {

            string Nome;
            int SobraNome;
            string DataNascimento;
            float Salario;
            int i;

            do
            {
                Console.WriteLine("Digite o seu Nome:");
                Nome = Console.ReadLine();

            } while (Nome.Length > 18);

            SobraNome = 18 - Nome.Length;

            for (i = 0; i < SobraNome; i++)
            {

                Nome = Nome + " ";
            }

            Console.WriteLine(Nome.Length);

            Console.ReadKey();
        }
    }
}
