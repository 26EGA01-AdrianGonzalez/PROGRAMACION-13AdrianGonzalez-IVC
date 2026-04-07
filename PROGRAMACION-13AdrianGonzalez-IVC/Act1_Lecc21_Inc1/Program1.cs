using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("== DIAS DE LA SEMANA ==");
        Console.Write("Ingrese un numero (1-7): ");
        // Variables
        int num; 
        num = int.Parse(Console.ReadLine());

        // Lógica de decisión
        if (num == 1) Console.WriteLine("Hoy es lunes");
        else if (num == 2) Console.WriteLine("Hoy es martes");
        else if (num == 3) Console.WriteLine("Hoy es miércoles");
        else if (num == 4) Console.WriteLine("Hoy es jueves");
        else if (num == 5) Console.WriteLine("Hoy es viernes");
        else if (num == 6) Console.WriteLine("Hoy es sábado");
        else if (num == 7) Console.WriteLine("Hoy es domingo");
        else
        {
            Console.WriteLine("Ese numero no es valido, bro.");
        }
    }
}