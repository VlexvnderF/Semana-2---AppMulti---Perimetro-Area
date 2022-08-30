using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");
            //Declaració variablaes

            int edad = 34;            
            string nombre = "hugo";
            decimal sueldo = 10000;
            bool esNuevo = true;

            int edad2 ;
            string nombre2 ;
            decimal sueldo2;
            bool esNuevo2;

            edad2 = 34;
            nombre2 = "hugo2";
            sueldo2 = 5000;


            //Sentencias
            if (edad>18)
            {
                Console.WriteLine("Es Mayor Edad");
            }
            if (sueldo>2000)
            {
                Console.WriteLine("Millonario");
            }
            else
            {
                Console.WriteLine("Pobre");
            }
            switch (edad2)
            {
                case 20:
                    Console.WriteLine("Es Joven");
                    break;
                case 30:
                    Console.WriteLine("Es Adulto");
                    break;
                default:
                    break;
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(nombre);
            }



            //Clases
            Persona persona = new Persona();

            persona.Nombres = "Juan José";
            persona.Apellidos = "Torrico López";
            persona.Edad = 56;

            Persona persona1 = new Persona
            {
                Nombres = "Yury Yovanna",
                Apellidos = "Márquez Montes",
                Edad = 54
            };


            persona.AsignarNombresCompletos();
            Console.WriteLine(persona.NombresCompletos);

                               
            Console.WriteLine(persona.Nombres);
            Console.WriteLine(persona.Apellidos);
            Console.WriteLine(persona.Edad);
            Console.WriteLine(persona.GetNombresCompletos());


            Console.WriteLine(persona1.Nombres);
            Console.WriteLine(persona1.Apellidos);
            //Console.WriteLine(persona1.GetNombresCompletos());


            Console.Read();

        }
    }
}

