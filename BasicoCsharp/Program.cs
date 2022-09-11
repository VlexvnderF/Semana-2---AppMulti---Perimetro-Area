using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 0;
            int valor2 = 0;
            int valor3 = 0;
            int valor4 = 0;
            int valor5 = 0;
            int valor6 = 0;
            int valor7 = 0;
            int valor8 = 0;

            Console.WriteLine("Ingrese x1:");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese y2:");
            valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese x2:");
            valor3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese y2:");
            valor4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese x3:");
            valor5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese y3:");
            valor6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese x4:");
            valor7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese y4:");
            valor8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Datos correctamente ingresados");

            Rectangulo rectangulo = new Rectangulo
            {
                x1 = valor1,
                y1 = valor2,
                x2 = valor3,
                y2 = valor4,
                x3 = valor5,
                y3 = valor6,
                x4 = valor7,
                y4 = valor8,
            };
            Console.WriteLine("El valor del área es: ");
            Console.WriteLine(rectangulo.s());
            Console.WriteLine("El valor del perimétro es: ");
            Console.WriteLine(rectangulo.p());

            Console.Read();
        }
    }
}

