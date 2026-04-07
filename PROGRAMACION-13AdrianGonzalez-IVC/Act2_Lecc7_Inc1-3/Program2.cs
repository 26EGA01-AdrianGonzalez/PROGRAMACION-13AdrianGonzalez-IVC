internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la nota:");
        double nota = double.Parse(Console.ReadLine());

        if (nota >= 91) Console.WriteLine("La nota es excelente");
        else if (nota >= 81) Console.WriteLine("La nota es muy buena");
        else if (nota >= 71) Console.WriteLine("La nota es buena");
        else if (nota >= 60) Console.WriteLine("La nota es regular");
        else Console.WriteLine("La nota es pesima");
    }
}
