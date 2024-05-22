using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Ejercicio 1
        Console.WriteLine("Ingrese un número para invertir:");
        string cadena = Console.ReadLine();
        int num;
        bool resultado = int.TryParse(cadena, out num);

        if (resultado)
        {
            int invertido = 0;
            int digito;
            int original = num;

            if (num > 0)
            {
                while (num > 0)
                {
                    digito = num % 10;
                    invertido = invertido * 10 + digito;
                    num /= 10;
                }
            }
            Console.WriteLine("El número invertido de {0} es: {1}", original, invertido);
        }

        // Ejercicio 2
        Console.WriteLine("¿Desea usar la calculadora? 1: sí, 0: no");
        string operacion = Console.ReadLine();
        int num3;

        if (int.TryParse(operacion, out num3) && num3 == 1)
        {
            int num1 = LeerNumero("Ingrese el primer número:");
            int num2 = LeerNumero("Ingrese el segundo número:");
            int operador = LeerOperacion();

            int resultadoCalculo = RealizarOperacion(num1, num2, operador);

            Console.WriteLine("El resultado es: " + resultadoCalculo);
        }

        // Ejercicio 3
        while (true)
        {
            Console.Write("Por favor, ingrese un número (o 'q' para salir): ");
            string input = Console.ReadLine();

            // Verificar si el usuario desea salir
            if (input.ToLower() == "q")
            {
                break;
            }

            // Intentar convertir la entrada a un número
            if (double.TryParse(input, out double numero))
            {
                Console.WriteLine("Seleccione una operación:");
                Console.WriteLine("1. Valor absoluto");
                Console.WriteLine("2. Cuadrado");
                Console.WriteLine("3. Raíz cuadrada");
                Console.WriteLine("4. Seno");
                Console.WriteLine("5. Coseno");
                Console.WriteLine("6. Parte entera");
                Console.WriteLine("Ingrese el número de la operación que desea realizar:");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        double valorAbsoluto = Math.Abs(numero);
                        Console.WriteLine("El valor absoluto de {0} es {1}", numero, valorAbsoluto);
                        break;

                    case "2":
                        double cuadrado = Math.Pow(numero, 2);
                        Console.WriteLine("El cuadrado de {0} es {1}", numero, cuadrado);
                        break;

                    case "3":
                        double raizCuadrada = Math.Sqrt(numero);
                        Console.WriteLine("La raíz cuadrada de {0} es {1}", numero, raizCuadrada);
                        break;

                    case "4":
                        double seno = Math.Sin(numero);
                        Console.WriteLine("El seno de {0} es {1}", numero, seno);
                        break;

                    case "5":
                        double coseno = Math.Cos(numero);
                        Console.WriteLine("El coseno de {0} es {1}", numero, coseno);
                        break;

                    case "6":
                        int parteEntera = (int)numero;
                        Console.WriteLine("La parte entera de {0} es {1}", numero, parteEntera);
                        break;

                    default:
                        Console.WriteLine("Operación no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
            }

            Console.WriteLine(); // Línea en blanco para separar iteraciones
        }

        // Ejercicio 4: Determinar el máximo y mínimo entre dos números
        int numero1 = LeerNumero("Ingrese el primer número para comparar:");
        int numero2 = LeerNumero("Ingrese el segundo número para comparar:");

        int maximo = Math.Max(numero1, numero2);
        int minimo = Math.Min(numero1, numero2);

        Console.WriteLine("El máximo entre {0} y {1} es {2}", numero1, numero2, maximo);
        Console.WriteLine("El mínimo entre {0} y {1} es {2}", numero1, numero2, minimo);

        Console.WriteLine("Programa terminado.");
    }

    private static int LeerNumero(string mensaje)
    {
        int numero;
        while (true)
        {
            Console.WriteLine(mensaje);
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out numero))
            {
                return numero;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            }
        }
    }

    private static int LeerOperacion()
    {
        int operador;
        while (true)
        {
            Console.WriteLine("Ingrese la operación: 1: suma, 2: resta, 3: multiplicar, 4: dividir");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out operador) && operador >= 1 && operador <= 4)
            {
                return operador;
            }
            else
            {
                Console.WriteLine("Operación no válida. Por favor, ingrese un número del 1 al 4.");
            }
        }
    }

    private static int RealizarOperacion(int num1, int num2, int operador)
    {
        int resultado = 0;
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
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: División por cero.");
                    throw new DivideByZeroException();
                }
                break;
        }
        return resultado;
    }
}
