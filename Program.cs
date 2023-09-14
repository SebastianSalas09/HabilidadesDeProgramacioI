using System;
using System.Security.Cryptography;
using System.Timers;

namespace HabilidadesDeProgramacioI
{
    internal class Program
    {
        static void Main(string[] args)
        {


            switch (useResponse)
            {
                case "1":
                    Rambom aleatorio = new Ramdon();
                    int resultado = aleatorio.Next(0, 200);
                    RandomNumber(resultado);
                    break;
                case "2":
                    int Resltado = addNumber 
                    Console.Write("El resultado es {resultado}");
                    break;
                case "3":




            }

            //Ejercicio 16 

            Console.WriteLine("Ingrese el numero de hombres");
            string inicio4 = Console.ReadLine();
            Consolole.WriteLine("Ingrese el numero de mujeres");
            string inicio5 = Console.ReadLine();
            int total = (inicio4 + inicio5);
            double hom = inicio4 * 100 / total;
            double muj = inicio5 * 100 / total;
            Consolore.WriteLine($"El porcentaje de los hombres son" + hom);
            Console.WriteLine($"El porcentaje de las mujeres son" +  muj);  

            //Ejercicio14
            Console.WriteLine("Ingrese el valor de su temperatura");
            string inicio3 = ConsoleReadLine();
            int num3 = Int32.Parse(inicio3);
            bool mayoracero = inicio3 >= 0;
            bool menoracero = inicio3 < 0;

            if (mayoracero) {
                Console.WriteLine("Puede continuar" + mayoracero); 
            }

            if (menoracero) {
                Console.WriteLine("no puede continuar intente dar otro valor" + menoracero);
            }

            else if(conti)
                Console.WriteLine("Ingrese el valor de la Altura de su cilindro");
                string inicio = Console.ReadLine();
                int Altura1 = Int32.Parse(inicio);
                Console.WriteLine("Ingrese el valor del Radio de su cilindro");
                string Radio = Console.ReadLine();
                double Radio1 = double.Parse(Radio);
                double perimetro = ((Math.PI * Math.Pow(Radio1, 2)));
                Console.WriteLine("El valor de su Perimetro es" + perimetro * Altura1);
            }




            //Ejercicio13
            Console.WriteLine("Ingrese su temperatura");
            string inicio2 = Console.ReadLine();    
            int Celsius = Int32.Parse(inicio2);
            double Fahrenheit = 9 / 5;
            double respuesta = (Celsius / Fahrenheit); 
            Console.WriteLine("Su valor en farenheit es" + respuesta + 32)



            //Ejercicio12
            Console.WriteLine("Ingrese su valor de Centimetros");
            string inicio1 = Console.ReadLine();
            int Centimetros = Int32.Parse(inicio1);
            double Yardas = 91.44;
            double Res1 = (Centimetros / Yardas);
            Console.WriteLine("Su resultado en yardas es" + Res1);
            //Metros
            double Metros = 100;
            double Res2 = (Centimetros / Metros);
            Console.WriteLine("Su valor en metros es" + Res2);
            //Pies
            double Pies = 30.48;
            double Res3 = (Centimetros / Pies);
            Console.WriteLine("Su valor en pies es" + Res3);
            //Pulgadas
            double Pulgadas = 2.54;
            double Res4 = (Centimetros / Pulgadas);
            Console.WriteLine("Su valor en pulgadas es" + Res4);


            //Ejercicio11
            Console.WriteLine("Ingrese el valor de la Altura de su cilindro");
            string inicio = Console.ReadLine();
            int Altura1 = Int32.Parse(inicio);
            Console.WriteLine("Ingrese el valor del Radio de su cilindro");
            string Radio = Console.ReadLine();
            double Radio1 = double.Parse(Radio);
            double perimetro = ((Math.PI * Math.Pow(Radio1, 2)));
            Console.WriteLine("El valor de su Perimetro es" + perimetro * Altura1);


            //Ejercicio10
            Console.WriteLine("Ingrese la Base triangulo");
            string Entrada = Console.ReadLine();
            int Base = Int32.Parse(Entrada);
            Console.WriteLine("Ingrese el valor de la Altura del triangulo");
            string Entrada1 = Console.ReadLine();
            int Altura = Int32.Parse(Entrada1);
            //Altura
            double area = ((Base * Altura) / 2);
            Console.WriteLine("La altura del triangulo es" + Altura);
            //Perimetro 
            double Perimetro = ((Math.Sqrt(Base * Base + Altura * Altura)) + Base + Altura);    
            Console.WriteLine("El perimetro del triangulo es" + Perimetro);
            

            //Ejercicio6
            Random aleatorio = new Random();
            Console.WriteLine();
            int resultado = aleatorio.Next(0, 200);
            Console.WriteLine(resultado);   
            double porcentaje = 1.3;
            double num2 = (porcentaje * resultado);
            Console.WriteLine("numero" + aleatorio);

            double num3 = resultado + num2;
            Console.WriteLine("numero aumentado a 30%:" + num3);


            //ñplolo

            //Ejercicio1

            Console.WriteLine("ingrese un numero ");
            string numero = Console.ReadLine();
            int num = int.Parse(numero);
            Console.WriteLine("El numero ingresado es:" + (num + 1));
        }
                   
    }
}



public static void RandonNumber (double resultado)
{
    Random aleatorio = new Random();
    Console.WriteLine();
    int resultado = aleatorio.Next(0, 200);
    Console.WriteLine(resultado);
    double porcentaje = 1.3;
    double num2 = (porcentaje * resultado);
    Console.WriteLine("numero" + aleatorio);

    double num3 = resultado + num2;
    Console.WriteLine("numero aumentado a 30%:" + num3);
}

public static int Perimetertherectangle ()
{
    Console.WriteLine("Ingrese la Base triangulo");
    string Entrada = Console.ReadLine();
    int Base = Int32.Parse(Entrada);
    Console.WriteLine("Ingrese el valor de la Altura del triangulo");
    string Entrada1 = Console.ReadLine();
    int Altura = Int32.Parse(Entrada1);
    //Altura
    double area = ((Base * Altura) / 2);
    Console.WriteLine("La altura del triangulo es" + Altura);
    //Perimetro 
    double Perimetro = ((Math.Sqrt(Base * Base + Altura * Altura)) + Base + Altura);
    Console.WriteLine("El perimetro del triangulo es" + Perimetro);

}
