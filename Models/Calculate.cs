using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculadora.Models
{
    public class Calculate
    {
        //metodos
        public void Somar(int x ,int y)
        {
            Console.WriteLine($"{x} + {y} = { x + y}");
        }
        public void Subtrair(int x ,int y)
        {
            Console.WriteLine($"{x} - {y} = { x - y}");
        }
        public void Multiplar(int x ,int y)
        {
            Console.WriteLine($"{x} * {y} = { x * y}");
        }
        public void Divisao(int x ,int y)
        {
            Console.WriteLine($"{x} / {y} = { x / y}");
        }
        //calculo usando a funcao math
        public void Potencia(int x, int y)
        {   double pot = Math.Pow(x , y);
            Console.WriteLine($"{x} ^ {y}= {pot}");
        }
        // funcao para calcular trigometria
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI /180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno,4)}");
        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI /180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(coseno,4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI /180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(tangente,4)}");
        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}