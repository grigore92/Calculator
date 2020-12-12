using System;

class Program
{
    static void Main()
    {

        int primulTermen = Program.IntroducereaPrimuluiTermen();
        int alDoileaTermen = Program.IntroduAlDoileaTermen();
        string operatia = Program.SelectareaOperatiei();
        string instructiuneaAleasa = Program.InstructiuneaAleasa();


        if (instructiuneaAleasa == "x")
        {
            Program.CalcululCuAjutorulInstructiuniiif(primulTermen, alDoileaTermen,operatia);
        }
        if (instructiuneaAleasa == "y")
        {
            Program.CalcululCuAjutotulInstructiuniiswitch(primulTermen, alDoileaTermen, operatia);
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
    public static string SelectareaOperatiei()
    {
        Console.WriteLine("Pentru adunare apasa tasta A");
        Console.WriteLine("Pentru scadere apasa tasta B");
        Console.WriteLine("Pentru inmultire apasa tasta C");
        Console.WriteLine("Pentru impartie apasa tasta D");
        string operatia = Console.ReadLine();
        return operatia;
    }
    public static string InstructiuneaAleasa()
    {
        Console.WriteLine("pentru insturctiunea if apasa X");
        Console.WriteLine("pentru insturctiunea Swich apasa y");
        string instructiuneaAleasa = Console.ReadLine();
        return instructiuneaAleasa;
    }
    public static void CalcululCuAjutorulInstructiuniiif(int primulTermen, int alDoileaTermen, string operatia)
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
    public static void CalcululCuAjutotulInstructiuniiswitch(int primulTermen, int alDoileaTermen, string operatia)
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
                break;
        }
    }
}



