// See https://aka.ms/new-console-template for more information
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine("Hello, World!");
        int a;
        int b;
        a = 10;
        b = a;
        Console.WriteLine("valor de a:" + a);
        Console.WriteLine("valor de b:" + b);

        //ejercicio1
        string cadena = "";
        cadena = Console.ReadLine();
        int num;
        bool resultado = int.TryParse(cadena, out num);

        if (resultado)
        {
            int invertido = 0;
            int digito;

            if (num > 0)
            {
                while (num > 0)
                {
                    digito = num % 10;
                    invertido = invertido * 10 + digito;
                    num /= 10;
                }
            }
            Console.WriteLine("El numero invertido es:" + invertido);
        }




        //ejercicio2
        Console.WriteLine("Desea usar la calculadora? 1:si, 0:no");
        string operacion = Console.ReadLine();

        if (int.TryParse(operacion, out int num3))
        {
            while (num3 == 1)
            {
                Console.WriteLine("Ingrese el primer numero:");
                string n1 = Console.ReadLine();
                Console.WriteLine("Ingrese el segundo numero:");
                string n2 = Console.ReadLine();
                Console.WriteLine("Ingrese la operacion: 1:suma, 2:resta, 3:multiplicar, 4:dividir");
                string operaciones = Console.ReadLine();

                int resul; // Declaración de resultado fuera del switch

                bool res2 = int.TryParse(operaciones, out int operador);
                bool bol1 = int.TryParse(n1, out int num1);
                bool bol2 = int.TryParse(n2, out int num2);

                if (res2 && bol1 && bol2)
                {
                    switch (operador)
                    {
                        case 1:
                            resul = num1 + num2;
                            break;
                        case 2:
                            resul = num1 - num2;
                            break;
                        case 3:
                            resul = num1 * num2;
                            break;
                        case 4:
                            if (num2 != 0)
                            {
                                resul = num1 / num2;
                            }
                            else
                            {
                                Console.WriteLine("Error: división por cero.");
                                continue;
                            }
                            break;
                    }

                    Console.WriteLine("El resultado es: " + resul);
                }
                Console.WriteLine("¿Desea usar la calculadora de nuevo? 1:si, 0:no");
                operacion = Console.ReadLine();
            }
        }
    }
}
