internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingresa los 3 ángulos:");
        double a1 = double.Parse(Console.ReadLine());
        double a2 = double.Parse(Console.ReadLine());
        double a3 = double.Parse(Console.ReadLine());
        //Variables
        if (a1 + a2 + a3 != 180)
        {
            Console.WriteLine("No es un triángulo válido.");
        }
        else if (a1 == a2 && a2 == a3)
        {
            Console.WriteLine("Equilátero");
        }
        else if (a1 == a2 || a1 == a3 || a2 == a3)
        {
            Console.WriteLine("Isósceles");
        }
        else
        {
            Console.WriteLine("Escaleno");
        }
    }
}