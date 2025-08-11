using System; // Importa funcionalidades básicas, como entrada/salida por consola

class HolaMundo // Define una clase llamada HolaMundo
{
    static void Main(string[] args) // Método principal, punto de entrada del programa
    {
    Console.Write("¿Cuál es tu nombre? "); // Muestra una pregunta en la consola
    string nombre = Console.ReadLine();    // Lee lo que el usuario escribe y lo guarda en la variable 'nombre'
    Console.WriteLine($"¡Hola, {nombre}!"); // Saluda al usuario usando el nombre ingresado
    Console.WriteLine("¡Adiós!");           // Muestra un mensaje de despedida
    }
}
