using System;

int cislo, hadanecislo;
//Random rnd = new Random();
//cislo = rnd.Next(1, 100);
//int cislo=Random.Shared.Next();
int NahodneCislo() => Random.Shared.Next(1, 100); //lambda zápis
cislo = NahodneCislo();

while (true)
{
    try
    {
        
        Console.WriteLine("Hádej číslo");
        hadanecislo = Int32.Parse(Console.ReadLine());

        if (cislo == hadanecislo)
        {
            Console.WriteLine("Uhodl jste!");
            Console.WriteLine("Chcete hrát znovu? Y/N");

        }
        if (cislo > hadanecislo)
        {
            Console.WriteLine("Číslo je větší");
        }
        if (cislo < hadanecislo)
        {
            Console.WriteLine("Cislo je menší");
        }
    } catch(Exception)
    {
        Console.WriteLine("Zadejte číslo");
        continue;
    }   
}
Console.WriteLine("Konec");
Console.ReadKey();
