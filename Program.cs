using System;
using System.Timers;

namespace HabilidadesDeProgramacioI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio3
            

            //Ejercicio2
            Random aleatorio = new Random();
            Console.WriteLine();
            int resultado = aleatorio.Next(0, 200);
            Console.WriteLine(resultado);   
            double porcentaje = 1.3;
            double num2 = (porcentaje * resultado);
            Console.WriteLine("numero" + aleatorio);

            double num3 = resultado + num2;
            Console.WriteLine("numero aumentado a 30%:" + num3);




            //Ejercicio1

            Console.WriteLine("ingrese un numero ");
            string numero = Console.ReadLine();
            int num = int.Parse(numero);
            Console.WriteLine("El numero ingresado es:" + (num + 1));
        }
                   
    }
}