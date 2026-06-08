// EJERCICIO 4

/* Dada una cadena (un string) de texto ingresada por el usuario, realice las siguientes tareas */
Console.WriteLine("Ingresar un frase:");
string? cadena = Console.ReadLine();

/* Obtener la longitud de la cadena y muestre por pantalla. */
int longitud = cadena.Length;
Console.WriteLine($"La frase \'{cadena}\' tiene {longitud} caracteres.");

/* A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas distintas. */
Console.WriteLine("Ingresar segunda frase:");
string? cadena2 = Console.ReadLine();
Console.WriteLine($"Ambas frases concatenadas: {cadena}{cadena2}");

/* Extraer una subcadena de la cadena ingresada. */
string? subcadena = cadena.Substring(3);
Console.WriteLine($"Subcadena generada a partir del caracter 3 => {subcadena}");

/* Utilizando la calculadora creada anteriormente realizar las operaciones de dos 
números y mostrar por pantalla y mostrar en texto el resultado. */
// Continuo en la rama de CalculadoraV1