using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 33;
            int idadeFutura = idade + 5;
            int idadePassada = idade - 5;

            Console.WriteLine("Minha idade futura é " + idadeFutura);
            Console.WriteLine("Minha idade passada é " + idadePassada);
            Console.WriteLine("Minha idade é " + idade);
            Console.Read();
        }
    }
}
