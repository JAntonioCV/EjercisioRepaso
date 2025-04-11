using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercisioIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definicion variables
            int numero;

            //Entrada
            Console.WriteLine("Escriba un numero: ");
            numero = int.Parse(Console.ReadLine());

            //Proceso
            numero = numero + numero;

            //Salida
            Console.WriteLine("La Suma de dos veces el numero es: " + numero);

            Console.ReadKey();
        }
    }
}
