using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class Program
    {
        //Calcule el mayor y el menor número de un array de números long.

        static void Main(string[] args)
        {

            long[] numeros = { 100L, 50L, 0L, 42L, 30L }; 
            long mayor = numeros[0];
            long menor = numeros[0];

            for (int i = 0; i < numeros.Length; i++)
            {

                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }
                else if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"El numero mayor es {mayor} y el numero menor es {menor}");
        }
    }
}
