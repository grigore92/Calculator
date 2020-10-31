using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Intrudu primul termen");
        string primulTermen = Console.ReadLine();

        Console.WriteLine("Intrudu al doilea termen");
        string alDoileaTermen = Console.ReadLine();

        Console.WriteLine("Pentru operatia + tasteaza a");
        Console.WriteLine("Pentru operatia - tasteaza b");
        Console.WriteLine("Pentru operatia * tasteaza c");
        Console.WriteLine("Pentru operatia / tasteaza d");

        string operatia = Console.ReadLine();

        switch (operatia)
        {
            case "a":
                int suma = Convert.ToInt32(primulTermen) + Convert.ToInt32(alDoileaTermen);
                Console.WriteLine("Rezultatul este" + suma);
                break;
            case "b":
                int scaderea = Convert.ToInt32(primulTermen) - Convert.ToInt32(alDoileaTermen);
                Console.WriteLine("Rezultatul este" + scaderea);
                break;
            case "c":
                int inmultirea = Convert.ToInt32(primulTermen) * Convert.ToInt32(alDoileaTermen);
                Console.WriteLine("Rezultatul este" + inmultirea);
                break;
            case "d":
                int impatirea = Convert.ToInt32(primulTermen) / Convert.ToInt32(alDoileaTermen);
                Console.WriteLine("Rezultatul este" + impatirea);
                break;
        }
    }
}
