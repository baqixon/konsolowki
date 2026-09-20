using System;
using System.Collections.Generic;




class Liczby
{
    List<int> liczby = new List<int> { };
    public bool koniec = false;
    public string podana_liczba { protected get;  set; }
    public int liczba;
    public void WyswietlLiczby()
    {
        int ilosc = 0;
        int suma = 0;
        Console.WriteLine("Podane liczby:");
        foreach (int liczba in liczby)
        {
            Console.WriteLine(liczba);
            ilosc++;
            suma += liczba;
        }
        Console.WriteLine($"Liczba ocen: {ilosc}\n A ich średnia to   {(double)suma / ilosc:F2}");
    }
    public void wpiszLiczbe()
    {
        bool isNumber;
        while (true)
        {
            Console.WriteLine("Podaj ocenę 1-6 (lub napisz 'koniec' aby zakończyć):");
            podana_liczba = Console.ReadLine();
            isNumber = int.TryParse(podana_liczba, out liczba);
            if (podana_liczba.ToLower() == "koniec")
            {
                koniec = true;
            }
            else if (isNumber && liczba >= 1 && liczba <= 6)
            {
                liczby.Add(liczba);
            }
            else
            {
                Console.WriteLine("Niepoprawna ocena. Proszę podać liczbę z zakresu 1-6 lub napisać 'koniec' aby zakończyć.");
            }





            if (koniec)
            {
                break;
            }
        }
    }


}
class Program
{
    static void Main(string[] args)
    {
        Liczby liczby = new Liczby();
        liczby.wpiszLiczbe();
        liczby.WyswietlLiczby();


    } 
}