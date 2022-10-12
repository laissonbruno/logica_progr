using System;
using System.Globalization;

namespace Logica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double salario1, salario2;
            string nome1, nome2;
            int idade;
            char sexo;


            Console.WriteLine("Digite o nome da primeira pessoa");
            nome1 = Console.ReadLine();
            Console.WriteLine("Digite o salario da primeira pessoa");
            salario1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa");
            nome2 = Console.ReadLine();
            Console.WriteLine("Digite o salario da segunda pessoa");
            salario2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite uma idade");
            idade = int.Parse(Console.ReadLine(), CI);
            sexo = char.Parse(Console.ReadLine(), CI);


            Console.WriteLine(nome1);
            Console.WriteLine(salario1);
            Console.WriteLine(nome2);
            Console.WriteLine(salario2);

            Console.WriteLine(idade);
            Console.WriteLine(sexo);



        }
    }
}


