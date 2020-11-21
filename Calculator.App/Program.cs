using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introdu primul numar");
        int primulTermen = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introdu al doilea numar");
        int alDoileaTermen = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Pentru adunare apasa tasta A");
        Console.WriteLine("Pentru scadere apasa tasta B");
        Console.WriteLine("Pentru inmultire apasa tasta C");
        Console.WriteLine("Pentru impartie apasa tasta D");
        string operatia = Console.ReadLine();

        Console.WriteLine("pentru insturctiunea if apasa X");
        Console.WriteLine("pentru insturctiunea Swich apasa y");
        string instructiuneaAleasa = Console.ReadLine();

        if (instructiuneaAleasa == "x")
        {
            if (operatia == "A")
            {
                int suma = primulTermen + alDoileaTermen;
                Console.WriteLine("Rezultatul operatie este " + suma);
            }
            if (operatia == "B")
            {
                int suma = primulTermen - alDoileaTermen;
                Console.WriteLine("Rezultatul operatie este " + suma);
            }
            if (operatia == "C")
            {
                int suma = primulTermen * alDoileaTermen;
                Console.WriteLine("Rezultatul operatie este " + suma);
            }
            if (operatia == "D")
            {
                int suma = primulTermen / alDoileaTermen;
                Console.WriteLine("Rezultatul operatie este " + suma);
            }

        }
        if (instructiuneaAleasa == "Y")
        {
            switch (operatia)
            {
                case "A":
                    int suma = primulTermen + alDoileaTermen;
                    Console.WriteLine("Rezultatul operatie este " + suma);
                    break;
                case "B":
                    int scaderea = primulTermen - alDoileaTermen;
                    Console.WriteLine("Rezultatul operatiei este " + scaderea);
                    break;
                case "C":
                    int imultirea = primulTermen * alDoileaTermen;
                    Console.WriteLine("Rezultatul operatiei este " + imultirea);
                    break;
                case "D":
                    int impartirea = primulTermen / alDoileaTermen;
                    Console.WriteLine("Rezultatul operatiei este " + impartirea + ". FELICITARI");
                    //Console.WriteLine("Rezultatul operatiei este 25.FELICITARI");
                    break;
            }
        }
    }
}
