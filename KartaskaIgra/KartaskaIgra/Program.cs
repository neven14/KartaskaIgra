using System;

namespace KartaskaIgra
{
    class Program
    {
        static void Main(string[] args)
        {
          int karte, bodovi = 0;
            while (bodovi < 31)
            {
              Console.Write("Upisite broj karte:");
                karte = Convert.ToInt32(Console.ReadLine());
                if (karte > 13 || karte < 1)
                {
                 Console.WriteLine("Krivi unos!");
                 
                }
                bodovi += karte;
            }
       if (bodovi == 31)
            {
                Console.WriteLine("Pobjedili ste!");
            }
        else
            {
                Console.WriteLine("Izgubili ste!");
            }
        }
    }
}
