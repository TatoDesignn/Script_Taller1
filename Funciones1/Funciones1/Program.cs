using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Funciones1
{
    //Realizar una función que calcule si una cadena es palindroma
    internal class Program
    {

        static void Palindroma(string palabra, string invertida, int total, int conteo)
        {
            for (int i = 0, j = 0; i < palabra.Length && j < invertida.Length; i++, j++)
            {
                if (palabra[i] == invertida[j])
                {
                    if (conteo == total)
                    {
                        Console.WriteLine("Tu palabra es palindroma");
                    }
                    conteo++;
                }
                else
                {
                    Console.WriteLine("Tu palabra no es palindroma");
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            string palabra, invertida;
            char[] arreglo;
            int total, conteo = 1;
            bool activo = true;

            while (activo)
            {
                Console.WriteLine("Escribe una palabra o escibe 'salir' para cerrar: ");
                palabra = Console.ReadLine();

                if(palabra != "salir")
                {
                    arreglo = palabra.ToCharArray();

                    Array.Reverse(arreglo);

                    invertida = new String(arreglo);

                    total = palabra.Length;

                    Palindroma(palabra, invertida, total, conteo);
                }
                else
                {
                    Console.WriteLine("Saliste con exito");
                    break;
                }

            }
        }
    }
}
