using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

 

namespace ConsoleApplication15

{

    class Calculadora 

    {

        static void Main(string[] args)

        {

            Console.Title = "Mini Calculadora";

            string resp = "";

            do
            {

                int valor1 = 0;
                int valor2 = 0;

                int R = 0;

 

              

                Console.WriteLine("Presione el simbolo para realizar la operacion:n");

                Console.WriteLine("+ para sumar");

                Console.WriteLine("- para restar");

                Console.WriteLine("* para multiplicar");

                Console.WriteLine("/ para dividir");

                Console.Write("n Eliga Una Opcion: ");

                resp = Console.ReadLine();




                Console.WriteLine("Ingrese sus dos numeros");

                Console.Write("Valor1: ");


                Console.Write("Valor2: ");

                valor2 = int.Parse(Console.ReadLine());

                Console.WriteLine();

 

                switch (eleccion)

                {

                    case "+":

                        Console.WriteLine("El resultado de la suma es:");

                        R = valor1 + valor2;

                        Console.WriteLine("{0} + {1} = {2}", valor1, valor2, R);

                        break;

                    case "-":

                        Console.WriteLine("El resultado de la resta es:");

                        R = valor1 - valor2;

                        Console.WriteLine("{0} - {1} = {2}", valor1, valor2, R);

                        break;

                    case "*":

                        Console.WriteLine("El resultado de la multiplicacion es:");

                        R = valor1 * valor2;

                        Console.WriteLine("{0} * {1} = {2}", valor1, valor2, R);

                        break;

                    case "/":

                        Console.WriteLine("El resultado de la division es:");

                        R = valor1 / valor2;

                        Console.WriteLine("{0} / {1} = {2}", valor1, valor2, R);

                        break;

                }

                Console.Write("n¿Desea Continuar? s/n: ");

                resp = Console.ReadLine();

            }

            while (resp == "s" || resp == "s");

        }

    }

}
