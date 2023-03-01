int n1, suma = 0, conteo = 1;
Console.WriteLine("-------------------------------------");
Console.WriteLine("              Bienvenido          ");
Console.WriteLine("-------------------------------------");
Console.Write("Ingrese un número entero positivo: ");
n1 = int.Parse(Console.ReadLine());
while (conteo <= n1) 
{
    suma = suma + conteo;/*1,3,6,10,15*/
    conteo++;/*1,2,3,4,5*/
    Console.WriteLine("Numeros enteros: " + suma); 
    if (suma % 2 == 0)
    {
    }
    else
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Este es un número impar: " + suma);
        Console.WriteLine("---------------------------------");
    }
}
Console.WriteLine("--------------------------------------------");
Console.WriteLine(" Tabla de multiplicar del número ingreasdo");
Console.WriteLine("--------------------------------------------");
for (int i = 1;i <= 10; i++)
{
    Console.WriteLine(i + " * " + n1 + " = " + (i * n1));
}
Console.WriteLine("-----------------------------------------------------");
do
{
    n1 = n1 + 2;
    Console.WriteLine("El incremento del número ingresado en dos es: "+n1);
} while (n1 <= 20);
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Suma de los números: "+suma);
Console.WriteLine("-----------------------------------------------------");