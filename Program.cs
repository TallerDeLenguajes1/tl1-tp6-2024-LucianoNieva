// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

 Console.WriteLine("Hello, World!");
 int a;
 int b;
 a=10;
 b=a;
 Console.WriteLine("valor de a:"+a);
 Console.WriteLine("valor de b:"+b);

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
            digito = num%10;
            invertido = invertido*10+digito;
            num /= 10;
        }
    }
    Console.WriteLine("El numero invertido es:"+invertido);
}


