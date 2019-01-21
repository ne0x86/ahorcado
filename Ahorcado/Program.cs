using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    class Program
    {
        static char[] GeneraPalabra(string[] array1)
        {
            string palabra;
            Random aleatorio = new Random();
            palabra = array1[aleatorio.Next(0, array1.Length)];
            char[] tablero = new char[palabra.Length];
            tablero = palabra.ToCharArray();
            return tablero;
        }
        static void Main(string[] args)
        {
            string[] palabras = new string[] { "cosa", "moco", "pedo" };
            char[] tablero = GeneraPalabra(palabras);
            foreach (char ele in tablero)
            {
                Console.Write(ele+ " ");
            }
            Console.ReadKey();
        }
    }
}
