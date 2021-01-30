using System;

namespace GUIA_3_EJERCICIO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *PROGRAMACION ESTRUCTURADA G07L
             *REBECA SARAÍ ALVARENGA HERNÁNDEZ
             *
             *EJERCICIO #1 GUIA 3
             */

            double r, v;
            Console.WriteLine("Bienvenido, te solicitare nada mas el valor del radio.");
            Console.WriteLine("Ingrese por favor el radio...");
            r = Math.Pow(Convert.ToDouble(Console.ReadLine()), 3);
            v = 1.3333 * Math.PI * r;
            Console.WriteLine("\nEl volumen de la esfera es de " + v);
            Console.WriteLine("\nPresiona cualquier tecla para finalizar el programa...");
            Console.ReadKey();
        }
    }
}
