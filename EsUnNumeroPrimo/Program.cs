using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Reto #3
 * ¿ES UN NÚMERO PRIMO?
 * Fecha publicación enunciado: 17/01/22
 * Fecha publicación resolución: 24/01/22
 * Dificultad: MEDIA
 *
 * Enunciado: Escribe un programa que se encargue de comprobar si un número es o no primo.
 * Hecho esto, imprime los números primos entre 1 y 100.
 */

namespace EsUnNumeroPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ImprimirPrimos();
        }              

        private static bool ComprobarPrimos(int numero)
        { 
            bool esPrimo = true;
            
            for (int i = 2; i < numero; i++)
            {
                if(numero%i == 0) { esPrimo = false; }
            }

            if (esPrimo) { return true; }
            else { return false; }
        }

        private static void ImprimirPrimos()
        {
            for (int i = 2; i < 100; i++)
            {
                if (ComprobarPrimos(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    
}
