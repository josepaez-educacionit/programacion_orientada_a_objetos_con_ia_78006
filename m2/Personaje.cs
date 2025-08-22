public class Personaje
{
    // Propiedades
    public string Nombre { get; set; }
    public int Defensa { get; set; }
    public int Poder { get; set; }
    public int Salud { get; set; }

    // Constructor vacío
    public Personaje()
    {
    }

    // Constructor con parámetros
    public Personaje(string nombre, int defensa, int poder, int salud)
    {
        Nombre = nombre;
        Defensa = defensa;
        Poder = poder;
        Salud = salud;
    }

    // Método para mostrar información del personaje
    public override string ToString()
    {
        return $"Personaje {{ Nombre = {Nombre}, Defensa = {Defensa}, Poder = {Poder}, Salud = {Salud} }}";
    }
}
