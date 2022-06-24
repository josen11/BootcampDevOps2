// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bootcamp DevOps -2da Edición - Ejercicio 1");
Console.WriteLine("=============================================");
Console.WriteLine("=============================================");
Console.WriteLine("Paso 1: Por favor ingresa una palabra para obtener los resultados");
var cadena = Console.ReadLine();
Console.WriteLine("=============================================");
Console.WriteLine("Paso 2: Analizar Resultados ");
Console.WriteLine($"Mostrar sus dos primeras letras: {cadena.ToString().Substring(0,2)}");
Console.WriteLine($"Mostrar sus tres primeras letras: {cadena.ToString().Substring(0,3)}");
Console.WriteLine($"Mostrar sus dos ultimas letras: {cadena.ToString().Substring(cadena.Length-2, 2)}");
Console.WriteLine($"Mostrar sus dos primeras letras: {cadena.ToString().Substring(cadena.Length-1, 1)}");
Console.WriteLine("=============================================");
Console.WriteLine("PD. Espero salir seleccionado =D");
Console.WriteLine("=============================================");