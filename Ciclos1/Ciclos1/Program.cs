using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos1
{
    internal class Program
    {
        //Usando un ciclo do-while calcule la suma de los primeros n números impares.
        static void Main(string[] args)
        {
            int numero;
            string temp;

            while (true)
            {
                int conteo = 0;

                Console.WriteLine("Escribe la cantidad  o escibe 'salir' para cerrar:");
                temp= Console.ReadLine();

                if(temp != "salir")
                {
                    if (int.TryParse(temp, out numero))
                    {
                        do
                        {
                            if (conteo % 2 != 0)
                            {
                                Console.WriteLine(conteo);
                            }
                            else
                            {
                                conteo++;
                                continue;
                            }
                            conteo++;
                        } while (conteo <= numero);
                    }
                    else
                    {
                        Console.WriteLine("Recuerda digitar un numero");
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
