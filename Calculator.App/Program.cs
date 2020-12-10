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

    // Aceasta functie este definita corect dar nu are nici un scop, adica nu face nimic.
    private static string SelectareaOperatiilor()
    {
        // Acest rand nu l-ai scris tu, a fost pus automat de Visual Studio. Dac nu ai nevoie de el, sterge-l.
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

    // Ce face acest rand? 
    public static string Selectarea private static int primulTermen;


    // Aici ai definit incorect o functie. 
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



    // Ce scop are acest rand aici? El e deja scris la linia 13.
    if (instructiuneaAleasa == "x")




        // Aici ai indicat gresit lista de parametri; nu parametrii, ci parantezele sunt indicate gresit.
    public static void CalcululCuAjutorulInstructiuniiIf((string operatiaPrimita, int primulTermeneSelecat, int alDoileaTermenSelectat))
    {
        // In toate aceste 4 if-uri folosesti o variabila inexistenta. 
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
            // Aici variabila "alDoileaTermen" nu ai definit-o. MAi intai trebuie sa o creezi apoi o poti folosi.
            int suma = primulTermen / alDoileaTermen;
            Console.WriteLine("Rezultatul operatie este " + suma);
        }
    }



    
    // Ce scop are acest rand aici? El e deja scris la linia 18.
    if (instructiuneaAleasa == "Y")




    public static void CalcululCuAjutorulInstructiuniiSwich(string operatiaPrimita, int primulTermenSelectat, int alDoileaTermenSelectat)
    {
        // In toate cele 4 "case"-uri de mai jos, variabila "alDoileaTermen" v-a avea mereu valoarea zero.
        int alDoileaTermen = 0;

        // Folosesti o variabila inexistenta.
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









