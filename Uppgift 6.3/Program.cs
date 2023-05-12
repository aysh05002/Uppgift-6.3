using System;

class program
{
    static int Störst(int tal1, int tal2)
    {
        int x = 0;
        if (tal1 > tal2)
        {
            x = tal1;
        }
        else if (tal2 > tal1)
        {
            x = tal2;
        }
        else if (tal1 == tal2)
        {
            x = tal1;
        }
        return x;
    }
    static int Addera(int tal1, int tal2, int tal3)
    {
        return tal1 + tal2 + tal3;
    }
    static void Main(string[] args)
    {
        string val = "";
        do
        {
            Console.WriteLine("1. Addera tre tal \n2. Stösta talet av två tal \n3. Avsluta programet");
            val = Console.ReadLine();
            switch (val)
            {
                case "1":
                    Console.WriteLine("Skriv in tre tal");
                    int x = Convert.ToInt32(Console.ReadLine());
                    int y = Convert.ToInt32(Console.ReadLine());
                    int z = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"summan av talen är {Addera(x, y, z)}");
                    Console.ReadKey();
                    Console.WriteLine();
                    break;
                case "2":
                    Console.WriteLine("Skriv in två tal");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Största talet är {Störst(a, b)}");
                    Console.ReadKey();
                    Console.WriteLine();
                    break;
                default:
                    break;
            }

        } while (val != "3");
    }
}