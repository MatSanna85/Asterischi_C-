using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int righe;

        while (true)
        {
            Console.WriteLine("Scrivi un numero (altrimenti 'esc' per uscire): ");
            string s = Console.ReadLine();

            if (s == "esc")
            {
                Console.WriteLine("Arrivederci");
                break;
            }

            righe = Convert.ToInt32(s);
            for (int r = 1; r <= righe; r++)
            {
                for (int ast = 1; ast <= r; ast++)
                {
                    Console.Write("* ");
                    
                }
                Console.Write("\n");

            }
           

        }

    }
}