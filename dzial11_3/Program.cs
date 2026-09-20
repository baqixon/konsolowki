using System;

class KontoBankowe
{
    private double saldo;
    public double Saldo
    {
        get { return saldo; }
        private set { saldo = value; }
    }
    public KontoBankowe()
    {
        saldo = 0;
    }
    public KontoBankowe(double saldoPoczatkowe)
    {
        saldo = saldoPoczatkowe >= 0 ? saldoPoczatkowe : 0;
    }
    public void Wplac(double kwota)
    {
        if (kwota > 0)
        {
            saldo += kwota;
            Console.WriteLine($"Wpłacono: {kwota} zł.");
        }
        else
        {
            Console.WriteLine("Kwota wpłaty musi być dodatnia!");
        }
    }


    public void Wyplac(double kwota)
    {
        if (kwota > 0 && kwota <= saldo)
        {
            saldo -= kwota;
            Console.WriteLine($"Wypłacono: {kwota} zł.");
        }
        else if (kwota > saldo)
        {
            Console.WriteLine($"Nie powiodła się wypłata {kwota} zł: Brak wystarczających środków na koncie!");
        }
        else
        {
            Console.WriteLine("Kwota wypłaty musi być dodatnia!");
        }
    }


    public void PokazSaldo()
    {
        Console.WriteLine($"Aktualny stan konta: {saldo} zł\n");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Testowanie konta z konstruktorem domyślnym ---");
        KontoBankowe konto1 = new KontoBankowe();
        konto1.PokazSaldo();
        Console.WriteLine("Test wpłaty");
        konto1.Wplac(500);
        konto1.PokazSaldo();
        Console.WriteLine("Test poprawnej wypłaty");

        konto1.Wyplac(200);
        konto1.PokazSaldo();

        Console.WriteLine("Test próby wypłaty kwoty większej niż sald");
        konto1.Wyplac(400); // Saldo wynosi teraz 300, więc wypłata 400 zł się nie uda
        konto1.PokazSaldo();

        Console.WriteLine("Test konta z konstruktorem z saldem początkowym");
        KontoBankowe konto2 =new KontoBankowe(1000);
        konto2.PokazSaldo();

         
    }
}