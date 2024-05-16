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
        int num3;

// Resto del código...

if (int.TryParse(operacion, out num3))
{
    if (num3 == 1)
    {

        Console.WriteLine("Ingrese el primer numero:");
        string n1 = Console.ReadLine();
        Console.WriteLine("Ingrese el segundo numero:");
        string n2 = Console.ReadLine();
        Console.WriteLine("Ingrese la operacion: 1:suma, 2:resta, 3:multiplicar, 4:dividir");
        string operaciones = Console.ReadLine();

        int operador;
        int num1;
        int num2;
        int resultado; // Declaración de resultado fuera del switch


        bool res2 = int.TryParse(operaciones, out operador);
        bool bol1 = int.TryParse(n1, out num1);
        bool bol2 = int.TryParse(n2, out num2);
        

        switch (operador)
        {

            case 1:
                resultado = num1 + num2;
                break;
            case 2:
                resultado = num1 - num2;
                break;
            case 3:
                resultado = num1 * num2;
                break;
            case 4:
                resultado = num1 / num2;
                break;
        }

        Console.WriteLine("El resultado es: " + resultado);

    }
}
}
