tp6
Bourdette, Irina Nicole
Ingeniería en Informática

# EJERCICIO 4

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