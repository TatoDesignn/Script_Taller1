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

        static string Palindroma(string palabra, string invertida, int total)
        {
            string resultado = "";
            int conteo = 1;

            for (int i = 0, j = 0; i < palabra.Length && j < invertida.Length; i++, j++)
            {
                if (palabra[i] == invertida[j])
                {
                    if (conteo == total)
                    {
                        resultado = "Tu palabra es palindroma";
                    }
                    conteo++;
                }
                else
                {
                    resultado = "Tu palabra no es palindroma";
                    break;
                }
            }

            return resultado;
        }

        static void Main(string[] args)
        {
            string palabra, invertida, resultado;
            char[] arreglo;
            int total;
            bool activo = true;

            while (activo)
            {
                Console.WriteLine("Escribe una palabra o escibe 'salir' para cerrar: ");
                palabra = Console.ReadLine();

                if (palabra != "salir")
                {
                    arreglo = palabra.ToCharArray();

                    Array.Reverse(arreglo);

                    invertida = new String(arreglo);

                    total = palabra.Length;

                    resultado = Palindroma(palabra, invertida, total);

                    Console.WriteLine(resultado);
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
