using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ActividadFunciones
{
    internal class Program
    {
        static string Primera()
        {
            string frase1 = "Tres tristes tigres";
            return frase1;
        }

        static string Segunda(string incompleta)
        {
            string frase2 = incompleta + " en un trigal";
            return frase2;
        }

        static string Tercera(int validador)
        {
            string frase3 = "";

            if (validador == 4)
            {
                frase3 = "en tres tristes trastos";
            }
            else
            {
                frase3 = "El parametro es incorrecto";
            }

            return frase3;
        }

        static void Cuarta()
        {
            string frase4 = "tragaban trigo tres tristes tigres.";
            return frase4;
        }

        static void Main(string[] args)
        {
            string incompleta = "tragaban trigo";

            Console.WriteLine("Completa la oracion haciendo uso de las funciones.\n");
            //Tres Tristes tigres, tragaban trigo en un trigal, en tres tristes trastos, tragaban trigo tres tristes tigres.

            string frase1 = ;
            string frase2 = ;
            string frase3 = ;
            string frase4 = ;

            Console.WriteLine($"{frase1} \n{frase2} \n{frase3} \n{frase4}");
        }
    }
}
