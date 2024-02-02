using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Cadena1
{
    internal class Program
    {
        //Lea una frase de mínimo 3 palabras y convierta cada palabra a minúscula y con mayúscula inicial como muestra el ejemplo: 

        static string Capitalizar(string[] arreglo)
        {
            string resultado;

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(arreglo[i].ToLower());
            }

            return resultado = string.Join(" ", arreglo);

        }

        static void Main(string[] args)
        {
            string palabra, resultado;
            string[] arreglo;

            while (true)
            {
                Console.WriteLine("Escribe una frase de minimo 3 palabras o escibe 'salir' para cerrar:");
                palabra = Console.ReadLine();

                if(palabra != "salir")
                {
                    arreglo = palabra.Split(' ');
                    if(arreglo.Length >= 3)
                    {
                        resultado = Capitalizar(arreglo);

                        Console.WriteLine(resultado);
                    }
                    else
                    {
                        Console.WriteLine("Recuerda que deben ser minimo 3 palabras");
                    }
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
