using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("== MENU DE BUZON (IF-ELSE) ==");
        Console.WriteLine("1. Ventas \n2. Recepcion \n3. Direccion \n4. Compras");
        // Variables
        int opcion;

        // Capturamos la opción 
        opcion = int.Parse(Console.ReadLine());

        //Evaluar las opciones
        if (opcion == 1)
        {
            Console.WriteLine("Te redirigimos a Ventas...");
        }
        else if (opcion == 2)
        {
            Console.WriteLine("Te redirigimos a Recepcion...");
        }
        else if (opcion == 3)
        {
            Console.WriteLine("Te redirigimos a Direccion...");
        }
        else if (opcion == 4)
        {
            Console.WriteLine("Te redirigimos con Compras...");
        }
        else
        {
            Console.WriteLine("Esa opcion no existe");
        }
    }
}