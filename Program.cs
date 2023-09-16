using System;
using System.Security.Cryptography;
using System.Timers;

namespace HabilidadesDeProgramacioI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
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

                case "4":   

                case "5":   

                case "6":

                case "7":

                case "8":

                case "9":

                case "10":




            }

            //Ejercicio 20
            Console.WriteLine("cual fue el resultado de ruleta ");
            string input12 = Console.ReadLine();
            int resul = Int32.Parse(input12);
            if (resul>=0 && resul<12)
            {
                Console.WriteLine("el resultado se encuentra en la primera docena ");
            }
            if (resul>=12 && resul<24)
            {
                Console.WriteLine("el resultado se encuentra en la segunda docena ");
            }
            if (resul>=24 && resul<36)
            {
                Console.WriteLine("el resultado se encuentra en la tercera docena ");
            }  


            //Ejercicio 19 
            Console.WriteLine("ingrese el valor del lado 1 ");
            string input9 = Console.ReadLine();
            float lado1 = float.Parse(input9);
            Console.WriteLine("ingrese el valor del lado 2 ");
            string input10 = Console.ReadLine();
            float lado2 = float.Parse(input10);
            Console.WriteLine("ingrese el valor del lado 3 ");
            string input11 = Console.ReadLine();
            float lado3 = float.Parse(input11);

            if (lado1 != lado2 && lado2 != lado3)
            {
                Console.WriteLine("Es un triangulo Escaleno");
            }
            if ((lado1 == lado2 && lado2 != lado3)||(lado1 == lado3 && lado3 != lado2)||(lado2 == lado3 && lado3 != lado1))
            {
                Console.WriteLine("Es un triangulo Isosceles");
            }
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Es un triangulo Equilatero");
            }


            //Ejercicio 18
            Console.WriteLine("ingrese el numero 1 ");
            string input14 = Console.ReadLine();
            float numero1 = float.Parse(input14);
            Console.WriteLine("ingrese el numero 2");
            string input15 = Console.ReadLine();
            float numero2 = float.Parse(input15);
            Console.WriteLine("ingrese el numero 3 ");
            string input16 = Console.ReadLine();
            float numero3 = float.Parse(input16);
            if (numero1 > numero2 && numero1 > numero3)
            {
                Console.WriteLine("el numero "+ numero1 +" es el mayor");
            }
            if (numero2 > numero1 && numero2 > numero3)
            {
                Console.WriteLine("el numero "+ numero2 +" es el mayor");
            }
            if (numero3 > numero2 && numero3 > numero1)
            {
                Console.WriteLine("el numero "+ numero3 +" es el mayor");
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
    string = Triangleresult "";
    Console.WriteLine("ingrese el valor del lado 1 ");
    string input9 = Console.ReadLine();
    float lado1 = float.Parse(input9);
    Console.WriteLine("ingrese el valor del lado 2 ");
    string input10 = Console.ReadLine();
    float lado2 = float.Parse(input10);
    Console.WriteLine("ingrese el valor del lado 3 ");
    string input11 = Console.ReadLine();
    float lado3 = float.Parse(input11);

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
