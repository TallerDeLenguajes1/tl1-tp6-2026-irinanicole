// EJERCICIO 4

/* Dada una cadena (un string) de texto ingresada por el usuario, realice las siguientes tareas */
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Ingresar un frase:");
Console.ResetColor();
string? cadena = Console.ReadLine();
if (!string.IsNullOrEmpty(cadena))
{
    /* Obtener la longitud de la cadena y muestre por pantalla. */
    int longitud = cadena.Length;
    Console.WriteLine($"\nLa frase \'{cadena}\' tiene {longitud} caracteres.");

    /* A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas distintas. */
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\nIngresar segunda frase:");
    Console.ResetColor();
    string? cadena2 = Console.ReadLine();
    if (!string.IsNullOrEmpty(cadena2))
    {
        Console.WriteLine($"\nAmbas frases concatenadas: {cadena}{cadena2}");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nLa cadena ingresada NO es válida\n");
        Console.ResetColor();
    }

    /* Extraer una subcadena de la cadena ingresada. */
    string? subcadena = cadena.Substring(3);
    Console.WriteLine($"\nSubcadena generada a partir del caracter 3 => {subcadena}\n");

    /* Utilizando la calculadora creada anteriormente realizar las operaciones de dos 
    números y mostrar por pantalla y mostrar en texto el resultado. */
    // Continuo en la rama de CalculadoraV1

    /* Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla */
    Console.WriteLine("\nMostrando cadena con el foreach: ");
    foreach (char c in cadena)
    {
        Console.WriteLine(c);
    }

    /* Buscar la ocurrencia de una palabra determinada en la cadena ingresada */
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\nIngrese una palabra: ");
    Console.ResetColor();
    string? palabraBuscada = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(palabraBuscada))
    {
        bool estaDentro = cadena.Contains(palabraBuscada);
        if(estaDentro)
        {
            Console.WriteLine("=> La palabra buscada si se encuentra en la frase.");
        }
        else
        {
            Console.WriteLine("=> La palabra buscada no se encuentra en niguna parte de la frase.");
        } 
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nLa palabra ingresada NO es válida\n");
        Console.ResetColor();
    }

    /* Convierta la cadena a mayúsculas y luego a minúsculas. */
    string? cadenaMayus = cadena.ToUpper();
    string? cadenaMinus = cadena.ToLower();

    Console.WriteLine($"\nCadena convertido a todo MAYUSCULAS: {cadenaMayus}");
    Console.WriteLine($"Cadena convertido a todo Minusculas: {cadenaMinus}\n");

}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nLa cadena ingresada NO es válida\n");
    Console.ResetColor();
}

/* Ingrese una cadena separada por caracteres que usted determine y muestre por pantalla los resultados */
// EJEMPLO:
// string texto = "Manzana,Pera,Banana";
// string[] frutas = texto.Split(',');

// frutas[0] = "Manzana"
// frutas[1] = "Pera"
// frutas[2] = "Banana"
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("\nIngrese una cadena separada por \';\' : ");
Console.ResetColor();
string? texto = Console.ReadLine();
if (!string.IsNullOrEmpty(texto))
{
    string[] arreglo = texto.Split(';');
    int i = 0;
    Console.WriteLine("\nCadena separada por \';\'");
    foreach (string parte in arreglo)
    {
        i++;
        Console.WriteLine($"Parte[{i}] = \'{parte}\'");
    }
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nLa cadena ingresada NO es válida\n");
    Console.ResetColor();
}