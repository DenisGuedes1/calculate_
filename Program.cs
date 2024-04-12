using System;
using calculadora.Models;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
            calc.Somar(10,15);
            calc.Somar(1,2);
            calc.Subtrair(10,50);
            calc.Multiplar(15,45);
            calc.Divisao(2,2);
            calc.Potencia(3, 3);
            calc.Seno(30);
            calc.Coseno(30);
            calc.Tangente(30);
            calc.RaizQuadrada(9);
            // int numeroIncremento = 10;
            // Console.WriteLine($"incrementando o numero = {numeroIncremento}");
            // // numero = numero + 1;
            // numeroIncremento++;
            // Console.WriteLine(numeroIncremento);

            // int numeroDecremento = 20;
            // Console.WriteLine($"Decrementando o nume = {numeroDecremento}");
            // numeroDecremento --;
            // Console.WriteLine(numeroDecremento);

        }
    }
}