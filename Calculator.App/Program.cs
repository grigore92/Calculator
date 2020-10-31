using System;

namespace Calculator.App
{
	class Program
	{
		static void Main(string[] args)
        {
            Console.WriteLine("Introdu primul numar:");
            string primulNumar = Console.ReadLine();

            Console.WriteLine("Introdu al doilea numar:");
            string alDoileaNumar = Console.ReadLine();

            Console.WriteLine("Pentru operatia \"Adunarea\" tasteaza \"a\"");
            Console.WriteLine("Pentru operatia \"Scaderea\" tasteaza \"b\"");
            Console.WriteLine("Pentru operatia \"Inmultirea\" tasteaza \"c\"");
            Console.WriteLine("Pentru operatia \"Impartirea\" tasteaza \"d\"");

            string operatia = Console.ReadLine();

            Console.WriteLine("se afiseazul rezultatul");
            if (operatia == "a")
            {
                int resultatul = Convert.ToInt32(primulNumar) + Convert.ToInt32(alDoileaNumar);
                Console.WriteLine(resultatul);
            }
            if (operatia == "b")
            {
                int resultatul = Convert.ToInt32(primulNumar) - Convert.ToInt32(alDoileaNumar);
                Console.WriteLine(resultatul);
            }
            if (operatia == "c")
            {
                int resultatul = Convert.ToInt32(primulNumar) * Convert.ToInt32(alDoileaNumar);
                Console.WriteLine(resultatul);
            }
            if (operatia == "d")
            {
                int resultatul = Convert.ToInt32(primulNumar) / Convert.ToInt32(alDoileaNumar);
                Console.WriteLine(resultatul);
            }
        }
	}
}
