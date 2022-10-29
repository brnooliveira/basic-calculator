internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtracao");
        Console.WriteLine("3 - Divisao");
        Console.WriteLine("4 - Multiplicacao");
        Console.WriteLine("5 - Sair");

        Console.WriteLine("----------------");
        Console.WriteLine("Selecione uma opcao:");

        short resultado = short.Parse(Console.ReadLine());

        switch (resultado)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;
        }


    }

    static void Soma()
    {
        Console.Clear();
        Console.WriteLine("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 + v2;

        Console.WriteLine($"O resultado da soma e: {resultado}");
        Console.ReadKey();

        Menu();
    }

    static void Subtracao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 - v2;

        Console.WriteLine($"O resultado e: {resultado}");
        Console.ReadKey();

        Menu();

    }

    static void Divisao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 / v2;

        Console.WriteLine($"O resultado e: {resultado}");
        Console.ReadKey();

        Menu();
    }

    static void Multiplicacao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro Valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 * v2;

        Console.WriteLine($"O resultado e: {resultado}");
        Console.ReadKey();

        Menu();
    }


}

