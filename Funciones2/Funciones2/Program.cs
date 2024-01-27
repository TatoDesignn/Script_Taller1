using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones2
{
    internal class Program
    {
        //Realice una función, que lea un número de máximo 8 cifras y luego sume cada dígito hasta obtener un valor de un solo dígito.

        static int Sumar(string numero)
        {
            int valor = 0;

            for(int i = 0; i < numero.Length; i++)
            {
                valor += int.Parse(numero[i].ToString());
            }

            return valor;
        }

        static void Main(string[] args)
        {
            int numero, total;
            string temp;

            while (true)
            {
                Console.WriteLine("Escribe un numero de max 8 cifras o escibe 'salir' para cerrar:");
                temp = Console.ReadLine();

                if(temp != "salir")
                {
                    if (int.TryParse(temp, out numero))
                    {
                        if (temp.Length <= 8)
                        {
                            total = Sumar(temp);

                            Console.WriteLine($"La suma de los digitos es igual a {total}");
                        }
                        else
                        {
                            Console.WriteLine("el numero debe ser de maximo 8 numeros");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Recuerda que debes escribir un numero");
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
