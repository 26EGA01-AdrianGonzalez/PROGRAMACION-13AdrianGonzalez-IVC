using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("==CONTROL DE ACCESO==");
        Console.Write("Ingrese la contraseña: ");
        // Variables
        string clave;

        // Captura la clave
        clave = Console.ReadLine();

        // Comparar la contraseña
        if (clave == "Password123")
        {
            Console.WriteLine("¡Bienvenida!");
        }
        else
        {
            Console.WriteLine("Ingreso prohibido.");
        }
    }
}