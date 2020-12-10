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

    private static string SelectareaOperatiilor()
    {
        throw new NotImplementedException();
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
    public static string Selectarea private static int primulTermen;

    Operatiilor()
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

    if (instructiuneaAleasa == "x")
    public static void CalcululCuAjutorulInstructiuniiIf((string operatiaPrimita, int primulTermeneSelecat, int alDoileaTermenSelectat))
    {
        if (operatia == "A")
        {
            int alDoileaTermen = 0;
            int suma = primulTermen + alDoileaTermen;
            Console.WriteLine("Rezultatul operatie este " + suma);
        }
        if (operatia == "B")
        {
            int alDoileaTermen = 0;
            int suma = primulTermen - alDoileaTermen;
            Console.WriteLine("Rezultatul operatie este " + suma);
        }
        if (operatia == "C")
        {
            int alDoileaTermen = 0;
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
    public static void CalcululCuAjutorulInstructiuniiSwich(string operatiaPrimita, int primulTermenSelectat, int alDoileaTermenSelectat)
    {
        int alDoileaTermen = 0;
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
                break;
        }
    }
}









