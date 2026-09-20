using System;
using System.Collections.Generic;
abstract class Pracownik
{
    public string Imie { get; set; }
    protected Pracownik(string imie)
    {
        Imie = imie;
    }
    public abstract double ObliczWynagrodzenie();
}
class PracownikEtatowy : Pracownik
{
    public double PensjaMiesieczna { get; set; }

    public PracownikEtatowy(string imie, double pensjaMiesieczna) : base(imie)
    {
        PensjaMiesieczna = pensjaMiesieczna;
    }
    public override double ObliczWynagrodzenie()
    {
        return PensjaMiesieczna;
    }
}

class Zleceniobiorca : Pracownik
{
    public double StawkaGodzinowa { get; set; }
    public double LiczbaGodzin { get; set; }
    public Zleceniobiorca(string imie, double stawkaGodzinowa, double liczbaGodzin) : base(imie){
        StawkaGodzinowa = stawkaGodzinowa;
        LiczbaGodzin = liczbaGodzin;
    }
    public override double ObliczWynagrodzenie()
    {
        return StawkaGodzinowa * LiczbaGodzin;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Pracownik> pracownicy = new List<Pracownik>
        {
            new PracownikEtatowy("Anna Kowalska", 6700),
            new Zleceniobiorca("Jan Nowak", 45, 160),
            new PracownikEtatowy("Katarzyna Wiśniewska", 8000),
            new Zleceniobiorca("Piotr Zieliński", 55, 120)
        };
        double sumaWynagrodzen = 0;

        Console.WriteLine("--- ZESTAWIENIE WYNAGRODZEŃ PRACOWNIKÓW ---");
        foreach (Pracownik p in pracownicy)
        {
            double wynagrodzenie = p.ObliczWynagrodzenie();
            Console.WriteLine($"Pracownik: {p.Imie,-20} | Wynagrodzenie: {wynagrodzenie,7} zł");
            sumaWynagrodzen += wynagrodzenie;
        }

        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"Łączna suma wynagrodzeń: {sumaWynagrodzen} zł");
    }
}