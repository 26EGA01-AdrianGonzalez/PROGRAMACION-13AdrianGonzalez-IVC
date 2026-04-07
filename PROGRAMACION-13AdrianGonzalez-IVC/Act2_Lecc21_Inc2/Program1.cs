using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("== SISTEMA DE ATENCION ==");
        Console.WriteLine("1. Ventas\n2. Recepcion\n3. Direccion\n4. Compras");
        Console.Write("Seleccione una opcion: ");

        int opt = int.Parse(Console.ReadLine());
        string depto = "", nombre = "", correo = "";

        if (opt == 1)
        {
            depto = "Ventas";
            nombre = "Juan Perez";
            correo = "ventas@empresa.com";
        }
        else if (opt == 2)
        {
            depto = "Recepcion";
            nombre = "Maria Lopez";
            correo = "recepcion@empresa.com";
        }
        else if (opt == 3)
        {
            depto = "Direccion";
            nombre = "Carlos Ruiz";
            correo = "direccion@empresa.com";
        }
        else if (opt == 4)
        {
            depto = "Compras";
            nombre = "Ana Garcia";
            correo = "compras@empresa.com";
        }

        if (depto != "")
        {
            Console.WriteLine($"\nBienvenido a {depto}");
            Console.WriteLine($"Responsable: {nombre}");
            Console.WriteLine($"Email: {correo}");
        }
        else
        {
            Console.WriteLine("Opcion invalida, bro.");
        }
    }
}