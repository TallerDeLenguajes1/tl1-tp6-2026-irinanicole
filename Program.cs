int num_leido;
string? s;

Console.WriteLine("Ingrese un número");
s = Console.ReadLine();
bool esUnNumero = int.TryParse(s, out num_leido);
if (esUnNumero)
{
    int invertido = 0;
    while(num_leido > 0)
    {
        int digito = num_leido % 10;
        invertido = (invertido * 10) + digito;
        num_leido = num_leido / 10;
    }
    Console.WriteLine($"Numero Invertido: {invertido}");
}