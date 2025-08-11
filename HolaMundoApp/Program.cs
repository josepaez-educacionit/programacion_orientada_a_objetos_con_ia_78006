// See https://aka.ms/new-console-template for more information
using System;

class HolaMundo
{
	static void Main(string[] args)
	{
		Console.Write("¿Cuál es tu nombre? ");
		string nombre = Console.ReadLine();
		Console.WriteLine($"¡Hola, {nombre}!");
	}
}
