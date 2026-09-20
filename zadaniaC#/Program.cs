string podana_liczba;
bool isNumber;
int liczba;
do
{
    Console.WriteLine("Proszę wpisać liczbę z zakresu 10-100:");
    podana_liczba  = Console.ReadLine();
    isNumber = int.TryParse(podana_liczba, out liczba);
    int.TryParse(podana_liczba, out liczba);
    if (!isNumber)
    {
        Console.WriteLine("Podana wartość nie jest liczbą, następnym razem proszę wpisać liczbę");
    }
    else if (liczba < 10)
    {
        Console.WriteLine("Podana liczba nie mieści się w zakresie 10-100, jest za mała. Następnym razem proszę wpisać liczbę z zakresu 10-100");
    }
    else if (liczba > 100)
    {
        Console.WriteLine("Podana liczba nie mieści się w zakresie 10-100, jest za duża. Następnym razem proszę wpisać liczbę z zakresu 10-100");
    }
    Console.WriteLine("\n");
    } while (!isNumber || !(liczba >= 10 && liczba <= 100));
Console.WriteLine($"Podana liczba '{liczba}' mieści się w zakresie 10-100, dziękuję za podanie odpowiedniej liczby, do widzenia! \n");