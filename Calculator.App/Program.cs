using System;
class Program
{
    //Rezolva sarcinile de mai jos insa fara a modifica functia Main().




    // Nu modifica absolut defel aceasta functie. NU adauga nici un rand in ea.
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

    private static string InstructiuneaAleasa()
    {
        throw new NotImplementedException();
    }

    // Imparte aceasta functie in doua functii.
    public static int IntroducereaPrimuluiTermen()
    {
        Console.WriteLine("Introdu primul numar");
        int primulTermen = Convert.ToInt32(Console.ReadLine());
        return primulTermen;
    }

    // Imparte aceasta functie in doua functii.
    public static int IntroduAlDoileaTermen()
    {
        Console.WriteLine("Introdu al doilea numar");
        int alDoileaTermen = Convert.ToInt32(Console.ReadLine());
        return alDoileaTermen;
    }
    // Imparte aceasta functie in 5 functii.
    public static string SelectareaOperatiei()
    {
        Console.WriteLine("Pentru adunare apasa tasta A");

        string instructiuneaAleasa = Console.ReadLine();
        return instructiuneaAleasa;
    }

    public static void CalcululCuAjutorulInstructiuniiif(int primulTermen, int alDoileaTermen, string operatia)
    {
        if (operatia == "A")
        {

            // Aceste doua linii punele in doua functii separate.
            int suma = primulTermen + alDoileaTermen;
            Console.WriteLine("Rezultatul operatie este " + suma);
        }
        if (operatia == "B")
        {

            // Aceste doua linii punele in doua functii separate.
            int suma = primulTermen - alDoileaTermen;
            Console.WriteLine("Rezultatul operatie este " + suma);
        }
        if (operatia == "C")
        {

            // Aceste doua linii punele in doua functii separate.
            int suma = primulTermen * alDoileaTermen;
            Console.WriteLine("Rezultatul operatie este " + suma);
        }
        if (operatia == "D")
        {
            // Aceste doua linii punele in doua functii separate.
            int suma = primulTermen / alDoileaTermen;
            Console.WriteLine("Rezultatul operatie este " + suma);
        }
    }

    public static void CalcululCuAjutotulInstructiuniiswitch(int primulTermen, int alDoileaTermen, string operatia)
    {

        switch (operatia)
        {

            case "A":
                // Aceste doua linii punele in doua functii separate.
                int suma = primulTermen + alDoileaTermen;
                Console.WriteLine("Rezultatul operatie este " + suma);
                break;
            case "B":
                // Aceste doua linii punele in doua functii separate.
                int scaderea = primulTermen - alDoileaTermen;
                Console.WriteLine("Rezultatul operatiei este " + scaderea);
                break;
            case "C":
                // Aceste doua linii punele in doua functii separate.
                int imultirea = primulTermen * alDoileaTermen;
                Console.WriteLine("Rezultatul operatiei este " + imultirea);
                break;
            case "D":
                // Aceste doua linii punele in doua functii separate.
                int impartirea = primulTermen / alDoileaTermen;
                Console.WriteLine("Rezultatul operatiei este " + impartirea + ". FELICITARI");
                break;
        }
    }
}


