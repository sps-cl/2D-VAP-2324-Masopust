using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Slovnik slovnik = new Slovnik();

        while (true)
        {
            string prikaz = Console.ReadLine();

            if (prikaz.StartsWith("Pridat:"))
            {
                string slovo = prikaz.Substring(7);
                slovnik.PridatSlovo(slovo);
            }
            else if (prikaz == "Zpet")
            {
                slovnik.Zpet();
            }
            else if (prikaz == "Vpred")
            {
                slovnik.Vpred();
            }
            else
            {
                slovnik.NeznamyPrikaz();
            }
        }
    }
}

class Slovnik
{
    private List<string> slova;
    private int aktualniIndex;

    public Slovnik()
    {
        slova = new List<string>();
        aktualniIndex = -1;
    }

    public void PridatSlovo(string slovo)
    {
        slova.Add(slovo);
        aktualniIndex = slova.Count - 1;
        Console.WriteLine(slovo);
    }

    public void Zpet()
    {
        if (aktualniIndex > 0)
        {
            aktualniIndex--;
            Console.WriteLine(slova[aktualniIndex]);
        }
        else
        {
            Console.WriteLine(slova[0]);
        }
    }

    public void Vpred()
    {
        if (aktualniIndex < slova.Count - 1)
        {
            aktualniIndex++;
            Console.WriteLine(slova[aktualniIndex]);
        }
        else
        {
            Console.WriteLine(slova[slova.Count - 1]);
        }
    }

    public void NeznamyPrikaz()
    {
        Console.WriteLine("Neznamy prikaz");
    }
}
