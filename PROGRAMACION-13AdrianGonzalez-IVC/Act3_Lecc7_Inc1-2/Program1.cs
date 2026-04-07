internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Día:");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("Mes (1-12):");
        int m = int.Parse(Console.ReadLine());

        if ((m == 3 && d >= 21) || m == 4 || m == 5 || (m == 6 && d < 21))
            Console.WriteLine("Primavera");
        else if ((m == 6 && d >= 21) || m == 7 || m == 8 || (m == 9 && d < 21))
            Console.WriteLine("Verano");
        else if ((m == 9 && d >= 21) || m == 10 || m == 11 || (m == 12 && d < 21))
            Console.WriteLine("Otoño");
        else
            Console.WriteLine("Invierno");
    }
}