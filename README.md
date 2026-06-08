tp6
Bourdette, Irina Nicole
Ingeniería en Informática

# EJERCICIO 4

## ¿String es una tipo por valor o un tipo por referencia? 
	==> Tipos por Valor (Value Types)
- Contienen el dato real directamente. 
- Se almacenan en una región de memoria rápida llamada STACK (pila). 
- Al copiar una variable a otra, se crea una copia exacta e independiente. Si se modifica la copia, la variable original no sufre ningún cambio.

	==> Tipos por Referencia (Reference Types)
- Almacenan una referencia (la dirección de memoria) donde realmente residen los datos.
- El dato en sí se guarda en una zona de memoria llamada HEAP (montón).
- Al copiar una variable a otra, solo se copia la dirección. Ambas variables apuntan al mismo objeto en memoria. Si modificas el objeto usando una de las variables, el cambio se verá reflejado en ambas.

 ==> Los datos tipo STRING:
- Son considerados formalmente tipos POR REFERENCIA, pero en la práctica se comportan como un tipo POR VALOR.
- Estructura y comportamiento clave:
	-> Ubicación en memoria: Al ser un tipo por referencia, el dato se almacena en el heap (montón), mientras que la 	variable en el stack (pila) guarda la dirección de memoria.
	-> Inmutabilidad: Una vez que se crea un string, su contenido no puede modificarse. Si realizas una operación (como 	concatenar o cambiar una letra), C# destruye el objeto anterior y crea uno nuevo en la memoria con el texto 	resultante.
	-> Asignaciones independientes: Al igual que ocurre con los tipos por valor, si copias un string en otra variable y 	luego lo modificas, ambas variables quedan separadas. Esto se debe a que la operación de modificación creará una 		nueva cadena, y la variable original seguirá apuntando a su valor inicial.
	-> Comparación: El operador == en los string está sobrecargado para comparar el **contenido** del texto en lugar de 	la dirección de memoria.

## ¿Qué secuencias de escape tiene el tipo string? 
En C#, las secuencias de escape son combinaciones de caracteres que comienzan con una barra invertida (\) y le indican al compilador que interprete el siguiente carácter de forma especial. Sirven para insertar caracteres reservados o no imprimibles dentro de un tipo string.

Algunos ejemplos de secuencias de escape para un tipo string, son:

**_Secuencia_	|	_Acción o Carácter Especial_**
- **\'** Comilla simple (para literales de tipo char)
- **\"** Comillas dobles (para incluir comillas en tu string)
- **\\** Barra invertida
- **\0** Carácter nulo
- **\a** Alerta (sonido de "beep")
- **\b** Retroceso (borra el carácter anterior)
- **\f** Salto de página
- **\n** Nueva línea
- **\r** Retorno de carro
- **\t** Tabulación horizontal
- **\v** Tabulación vertical
- **\u** Carácter Unicode exacto (Ej: \u2665 para un corazón)
- **\U** Carácter Unicode de 32 bits
- **\x** Carácter hexadecimal
- **\e** Carácter de escape (Disponible en C# 13 y versiones posteriores)


## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto? 

#### Alternativas a las Secuencias de Escape
Si no quieres lidiar con escribir barras invertidas constantemente, C# te proporciona dos alternativas muy útiles:

1. **Cadenas literales textuales (prefijo @)**: Al poner un **@** antes de las comillas, las secuencias de escape se ignoran por completo (se toman tal cual se escriben) y puedes abarcar varias líneas en tu código fuente.
	```C#
	string ruta = @"C:\Archivos de programa\dotnet";
	```

2. **Cadenas interpoladas (prefijo $)**: Te permiten insertar variables directamente dentro de las llaves **{ }** sin necesidad de concatenar con el símbolo +.
	```C#
	int edad = 30;
	string mensaje = $"Tengo {edad} años";
	```