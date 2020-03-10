using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaMercado
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listaMercado = new string[10];
            string item;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe um item da sua lista " + i);
                item = Console.ReadLine();
                listaMercado[i] = item;

            }
            Console.WriteLine("Nossa lista");
            foreach (var valor in listaMercado)
            {
            Console.WriteLine(valor);

            }
            Console.Read();
        }
    }
}
