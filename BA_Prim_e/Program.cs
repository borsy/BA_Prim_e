using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Kérem, adjon meg egy egész számot:");

        // Felhasználótól bekérjük az egész számot
        int szam = Convert.ToInt32(Console.ReadLine());

        // Ellenőrizzük, hogy a szám prím-e
        bool isPrime = IsPrime(szam);

        // Kiírjuk az eredményt
        if (isPrime)
        {
            Console.WriteLine($"{szam} prím szám.");
        }
        else
        {
            Console.WriteLine($"{szam} nem prím szám.");
        }

        Console.ReadLine();
    }

    // Függvény a prímságot ellenőrzésére
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
