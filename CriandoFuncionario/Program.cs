using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            //criar as variaveis idade(int), nome(string), nascimento(datetime), valorsalarial(decimal)-atribuir valor e imprimir
            int idade = 33;
            string nome = "Juliana";
            decimal valorSalarial = 20.000M;
            DateTime nascimento = new DateTime(1986, 05, 06);
            Console.WriteLine($"Minha idade é :{idade}" +$"Meu nome é : {nome}" + $"Meu salário é : {valorSalarial}");
            Console.WriteLine("Minha data de nascimento é " + nascimento.ToString("dd/mm/yyyy"));
            Console.ReadLine();
        }
    }
}
