// Para utilizar en Ejercicio 5
using System.Text.RegularExpressions;


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

/* Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación simple como cadena de caracteres  y que el sistema lo resuelva.
Por ej. ingrese por pantalla “582+2” y que le devuelva la suma de 582  con 2 */
// Ejercicio resuelto en la rama (CalculadoraV1) en el menu de operaciones (stwitch).

//////////////////////////////////////////////////////////////////////////////////////

/*  EJERCICIO 5  */

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n----------------------------------");
Console.WriteLine("VALIDACION DE DIRECCION WEB");
Console.WriteLine("----------------------------------\n");
Console.ResetColor();

Console.WriteLine("\nIngresar una direccion url o http o https:");
string? dirWeb = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(dirWeb))
{
    //string urlEjemplo1 = "https://google.com";
    //string urlEjemplo2 = "htp://invalida.com";
    Console.WriteLine($"Direccion ingresada: {dirWeb}");

    // Expresión regular para validar URLs HTTP o HTTPS
    string patronDirWeb = @"^(https?:\/\/)?(www\.)?([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,}(\/.*)?$";
    
    if (Regex.IsMatch(dirWeb, patronDirWeb))
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("La direccion web es válida.");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("La direccion web no es válida.");
    }
    Console.ResetColor();
    
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n\aERROR: la cadena ingresada es invalida\n");
    Console.ResetColor();
}

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("\n------FIN de Validacion de Direccion Web------\n");
Console.ResetColor();

//////////////////////////////////////////////////////////////////////////////////////

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n----------------------------------");
Console.WriteLine("VALIDACION DE CORREO ELECTRONICO");
Console.WriteLine("----------------------------------\n");
Console.ResetColor();

Console.WriteLine("\nIngresar un correo electronico:");
string? email = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(email))
{
    //string emailEjemplo = "usuario@dominio.com";
    Console.WriteLine($"Correo: {email}");

    // Expresión regular estándar para correos
    string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
    
    if (Regex.IsMatch(email, patronEmail))
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("El correo electrónico es válido.");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("El correo electrónico no es válido.");
    }
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n\aERROR: la cadena ingresada es invalida\n");
    Console.ResetColor();
}

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("\n------FIN de Validacion de Correo Electronico------\n");
Console.ResetColor();