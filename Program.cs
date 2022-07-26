using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_1___proyecto_consola_calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
           // int c = a + b;


            Console.Title = "Programa de calculadora basica \n\n "; 

            Console.WriteLine("semana 2 \n");
            

            Console.WriteLine("Escribe el primer numero");
           num1 = Convert.ToInt32  (Console.ReadLine());


            Console.WriteLine("Escribe el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());


            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();


        }
    }
}
