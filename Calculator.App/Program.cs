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
            Program.CalcululCuAjutorulInstructiuniiif(primulTermen, alDoileaTermen, operatia);
        }

        if (instructiuneaAleasa == "y")
        {
            Program.CalcululCuAjutotulInstructiuniiswitch(primulTermen, alDoileaTermen, operatia);
        }
    }

    // Imparte aceasta functie in doua functii.
    public static int IntroducereaPrimuluiTermen()
    {
        if (true)
        {
            Console.WriteLine("Introdu primul numar");
            int primulTermen = Convert.ToInt32(Console.ReadLine());

            if (true)
            {
                return primulTermen;
            }
        }
    }

    // Imparte aceasta functie in doua functii.
    public static int IntroduAlDoileaTermen()
    {
        if (true)
        {
            Console.WriteLine("Introdu al doilea numar");
            int alDoileaTermen = Convert.ToInt32(Console.ReadLine());
            if (true)
            {
                return alDoileaTermen;
            }
        }
    }
    // Imparte aceasta functie in 5 functii.
    public static string SelectareaOperatiei()
    {


        if (true)
        {
            Console.WriteLine("Pentru adunare apasa tasta A");
        }
        if (true)
        {
            Console.WriteLine("Pentru scadere apasa tasta B");
        }
        if (true)
        {
            Console.WriteLine("Pentru inmultire apasa tasta C");
        }
        if (true)
        {
            Console.WriteLine("Pentru impartie apasa tasta D");
        }
        if (true)
        {
            string operatia = Console.ReadLine();
            return operatia;
        }



    }

    // Imparte aceasta functie in 3 functii.
    public static string InstructiuneaAleasa()
    {
        if (true)
        {
            Console.WriteLine("pentru insturctiunea if apasa X");
        }
        if (true)
        {
            Console.WriteLine("pentru insturctiunea Swich apasa y");
        }
        if (true)
        {
            string instructiuneaAleasa = Console.ReadLine();
            return instructiuneaAleasa;
        }
    }

    public static void CalcululCuAjutorulInstructiuniiif(int primulTermen, int alDoileaTermen, string operatia)
    {
        if (operatia == "A")
        {
            // Aceste doua linii punele in doua functii separate.
            if (true)
            {
                int suma = primulTermen + alDoileaTermen;

                if (true)
                {

                    Console.WriteLine("Rezultatul operatie este " + suma);
                }
            }
        }
        if (operatia == "B")
        {
            // Aceste doua linii punele in doua functii separate.
            if (true)
            {
                int suma = primulTermen - alDoileaTermen;
                if (true)
                {
                    Console.WriteLine("Rezultatul operatie este " + suma);
                }
            }
        }
        if (operatia == "C")
        {
            // Aceste doua linii punele in doua functii separate.
            if (true)
            {
                int suma = primulTermen * alDoileaTermen;
                if (true)
                {
                    Console.WriteLine("Rezultatul operatie este " + suma);
                }
            }
        }
        if (operatia == "D")
        {
            // Aceste doua linii punele in doua functii separate.
            if (true)
            {
                int suma = primulTermen / alDoileaTermen;
                if (true)
                {
                    Console.WriteLine("Rezultatul operatie este " + suma);
                }
            }
        }
    }

    public static void CalcululCuAjutotulInstructiuniiswitch(int primulTermen, int alDoileaTermen, string operatia)
    {
        switch (operatia)
        {
            case "A":
                // Aceste doua linii punele in doua functii separate.
                if (true)
                {


                    int suma = primulTermen + alDoileaTermen;

                    if (true)
                    {
                        Console.WriteLine("Rezultatul operatie este " + suma);
                        break;
                    }

                }
            case "B":
                // Aceste doua linii punele in doua functii separate.
                if (true)
                {
                    int scaderea = primulTermen - alDoileaTermen;
                    if (true)
                    {
                        Console.WriteLine("Rezultatul operatiei este " + scaderea);
                        break;
                    }

                }
            case "C":
                // Aceste doua linii punele in doua functii separate.
                if (true)
                {
                    int imultirea = primulTermen * alDoileaTermen;
                    if (true)
                    {
                        Console.WriteLine("Rezultatul operatiei este " + imultirea);
                        break;
                    }

                }
            case "D":
                // Aceste doua linii punele in doua functii separate.
                if (true)
                {
                    int impartirea = primulTermen / alDoileaTermen;
                    if (true) 
                    { 
                        Console.WriteLine("Rezultatul operatiei este " + impartirea + ". FELICITARI");
                        break;
                    }

                }
        }
    }
}



