using System;

class Program
{
    static void Main()
    {
        int primulTermen = Program.IntroducereaPrimuluiTermen();
        int alDoileaTermen = Program.IntroduAlDoileaTermen();

        string operatia = Program.SelectareaOperatiilor();
        string instructiuneaAleasa = Program.SelecteazaInstructiuneaDorita();

        if (instructiuneaAleasa == "x")
        {
            Program.CalcululCuAjutorulInstructiuniiIf(operatia, primulTermen, alDoileaTermen);
        }

        if (instructiuneaAleasa == "y")
        {
            Program.CalcululCuAjutorulInstructiuniiSwich(operatia, primulTermen, alDoileaTermen);  
        }
    }

    public static int IntroducereaPrimuluiTermen()
    {
        Console.WriteLine("Introdu primul numar");
        int primulTermen = Convert.ToInt32(Console.ReadLine());

        return primulTermen;
    }

    public static int IntroduAlDoileaTermen()
    {
        Console.WriteLine("Introdu al doilea numar");
        int alDoileaTermen = Convert.ToInt32(Console.ReadLine());

        return alDoileaTermen;
    }

    public static string SelectareaOperatiilor()
    {
        Console.WriteLine("Pentru adunare apasa tasta A");
        Console.WriteLine("Pentru scadere apasa tasta B");
        Console.WriteLine("Pentru inmultire apasa tasta C");
        Console.WriteLine("Pentru impartie apasa tasta D");
        string operatia = Console.ReadLine();

        return operatia;
    }

    public static string SelecteazaInstructiuneaDorita()
    {
        Console.WriteLine("pentru insturctiunea if apasa X");
        Console.WriteLine("pentru insturctiunea Swich apasa y");
        string instructiuneaAleasa = Console.ReadLine();

        return instructiuneaAleasa;
    }

    public static void CalcululCuAjutorulInstructiuniiIf(string operatiaPrimita, int primulTermeneSelecat, int alDoileaTermenSelectat)

    {
        if (operatiaPrimita == "A")
        {
            int suma = primulTermeneSelecat + alDoileaTermenSelectat;
            Console.WriteLine("Rezultatul operatie este " + suma);
        }
        if (operatiaPrimita == "B")
        {
            int suma = primulTermeneSelecat - alDoileaTermenSelectat;
            Console.WriteLine("Rezultatul operatie este " + suma);
        }
        if (operatiaPrimita == "C")
        {
            int suma = primulTermeneSelecat * alDoileaTermenSelectat;
            Console.WriteLine("Rezultatul operatie este " + suma);
        }
        if (operatiaPrimita == "D")
        {
            int suma = primulTermeneSelecat / alDoileaTermenSelectat;
            Console.WriteLine("Rezultatul operatie este " + suma);
        }
    }

    public static void CalcululCuAjutorulInstructiuniiSwich(string operatiaPrimita, int primulTermenSelectat, int alDoileaTermenSelectat) 
    {
        switch (operatiaPrimita)
        {
            case "A":
                int suma = primulTermenSelectat + alDoileaTermenSelectat;
                Console.WriteLine("Rezultatul operatie este " + suma);
                break;
            case "B":
                int scaderea = primulTermenSelectat - alDoileaTermenSelectat;
                Console.WriteLine("Rezultatul operatiei este " + scaderea);
                break;
            case "C":
                int imultirea = primulTermenSelectat * alDoileaTermenSelectat;
                Console.WriteLine("Rezultatul operatiei este " + imultirea);
                break;
            case "D":
                int impartirea = primulTermenSelectat / alDoileaTermenSelectat;
                Console.WriteLine("Rezultatul operatiei este " + impartirea + ". FELICITARI");
                break;
        }
    }
}