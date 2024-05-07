int M(int num1, int num2)
{
    int resultado = 0;
    for (int i = 0; i < num2; i++)
    {
        resultado = resultado + num1;
    }
    return resultado;
}
void multiplicacion()
{
    Console.WriteLine("Ingrese el numero que va a multiplicar:");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese el numero por el cual va a multiplicar:");
    int b = Convert.ToInt32(Console.ReadLine());

    int resultado = M(a, b);
    Console.WriteLine($"{a} por {b} es igual a " + resultado);
}
multiplicacion();
