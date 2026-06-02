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


//----------------//
/* CALCULADORA V1 */
//----------------//

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("--- INICIO ---");
Console.WriteLine("CALCULADORA V1\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("¿Desea realizar una operación? SI(x)|NO(0) ");
Console.ResetColor();
string? leer = Console.ReadLine();
int seguir;
bool esOperable = int.TryParse(leer, out seguir);

if (esOperable)
{
    while (esOperable && seguir != 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nSelecciona una operación: ");
        Console.ResetColor();
        Console.WriteLine("(1): SUMA");
        Console.WriteLine("(2): RESTA");
        Console.WriteLine("(3): PRODUCTO");
        Console.WriteLine("(4): DIVISION");
        leer = Console.ReadLine();
        int operacion;
        esOperable = int.TryParse(leer, out operacion);
        
        int resultado = 0;
        if (esOperable)
        {
            int x,y;
            bool esEntero1, esEntero2;
            switch (operacion)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Operacion: SUMA");
                    Console.ResetColor();

                    Console.WriteLine("Ingrese el primer termino");
                    leer = Console.ReadLine();
                    esEntero1 = int.TryParse(leer, out x);
                    
                    Console.WriteLine("Ingrese el segundo termino");
                    leer = Console.ReadLine();
                    esEntero2 = int.TryParse(leer, out y);
                    if (esEntero1 && esEntero2)
                    {
                        resultado = x + y;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Datos ingresados incorrectos");
                        Console.ResetColor();
                    }
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Operacion: RESTA");
                    Console.ResetColor();
                    
                    Console.WriteLine("Ingrese el primer termino");
                    leer = Console.ReadLine();
                    esEntero1 = int.TryParse(leer, out x);
                    
                    Console.WriteLine("Ingrese el segundo termino");
                    leer = Console.ReadLine();
                    esEntero2 = int.TryParse(leer, out y);
                    if (esEntero1 && esEntero2)
                    {
                        resultado = x - y;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Datos ingresados incorrectos");
                        Console.ResetColor();
                    }
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Operacion: PRODUCTO");
                    Console.ResetColor();

                    Console.WriteLine("Ingrese el primer termino");
                    leer = Console.ReadLine();
                    esEntero1 = int.TryParse(leer, out x);
                    
                    Console.WriteLine("Ingrese el segundo termino");
                    leer = Console.ReadLine();
                    esEntero2 = int.TryParse(leer, out y);
                    if (esEntero1 && esEntero2)
                    {
                        resultado = x * y;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Datos ingresados incorrectos");
                        Console.ResetColor();
                    }
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Operacion: DIVISION");
                    Console.ResetColor();

                    Console.WriteLine("Ingrese el primer termino: ");
                    leer = Console.ReadLine();
                    esEntero1 = int.TryParse(leer, out x);
                    
                    Console.WriteLine("Ingrese el segundo termino DISTINTO DE CERO: ");
                    leer = Console.ReadLine();
                    esEntero2 = int.TryParse(leer, out y);
                    if (esEntero1 && esEntero2 && y != 0 )
                    {
                        resultado = x / y;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Datos ingresados incorrectos");
                        Console.ResetColor();
                    }
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Elija una opcion valida");
                    Console.ResetColor();
                    break;
            }

        } else {
            // Cambia el color del texto a rojo para indicar un error
            Console.ForegroundColor = ConsoleColor.Red;
            // Muestra el mensaje de error
            Console.WriteLine("Error: La opcion ingresada es inválida.");
            // Restaura el color original de la consola
            Console.ResetColor();
        }

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Resultado: {resultado}\n");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("¿Seguir operando? SI(x)|NO(0) ");
        Console.ResetColor();
        leer = Console.ReadLine();
        esOperable = int.TryParse(leer, out seguir);
    }

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