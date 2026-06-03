//----------------//
/* CALCULADORA V2 */
//----------------//

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("--- INICIO ---");
Console.WriteLine("CALCULADORA V2\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Ingrese un numero: ");
Console.ResetColor();
string? leer = Console.ReadLine();
double numero;
bool esOperable = double.TryParse(leer, out numero);

if (esOperable)
{
    double valor_abs = Math.Abs(numero);
    Console.WriteLine($"Valor Absoluto de {numero} = {valor_abs}");
    double cuadrado = Math.Pow(numero,2);
    Console.WriteLine($"{numero} al Cuadrado = {cuadrado}");
    double raiz_cuad = Math.Sqrt(numero);
    Console.WriteLine($"Raiz cuadrada de {numero} = {raiz_cuad}");
    double seno = Math.Sin(numero);
    Console.WriteLine($"Seno de {numero} = {seno}");
    double coseno = Math.Cos(numero);
    Console.WriteLine($"Coseno de {numero} = {coseno}");
    /* La parte entera de un tipo float */
    int parte_entera = (int)numero; // consultar si esto es realmente lo que me piden
    Console.WriteLine($"Parte entera de {numero} = {parte_entera}");

}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Error: el dato ingresado es inválido para operar.");
    Console.ResetColor();
}

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\nIngresar dos numeros");
Console.WriteLine("x = ");
string? leerX = Console.ReadLine();
Console.WriteLine("y = ");
string? leerY = Console.ReadLine();
Console.ResetColor();

int x, y;
bool esValidoX = int.TryParse(leerX, out x);
bool esValidoY = int.TryParse(leerY, out y);

if (esValidoX && esValidoY)
{
    int maximo = Math.Max(x,y);
    int minimo = Math.Min(x,y);
    Console.WriteLine($"El MAXIMO entre x={x} e y={y} es: {maximo}");
    Console.WriteLine($"El MINIMO entre x={x} e y={y} es: {minimo}");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Error: el dato ingresado es inválido para operar.");
    Console.ResetColor();
}


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\n--- Fin del Programa ---");
Console.ResetColor();