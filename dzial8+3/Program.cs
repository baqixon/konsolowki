int liczba = 0; string pomoc; List<int> list = new List<int>(); Console.WriteLine("podaj liczby do listy, możesz podać dowolną liczbę liczb, gdy będziesz chciał zakończyć to wpisz '0'"); while (true)

{



    pomoc = Console.ReadLine();

    int.TryParse(pomoc, out liczba);



    if (liczba == 0)

    {

        break;

    }

    else list.Add(liczba);

}
Console.WriteLine("Liczby w liście:");

for (int i = 0; i < list.Count; i++)

{

    if (list[i] < 0)

    {

        list.RemoveAt(i);

        i--;

    }



}
int suma = 0; foreach (int i in list)

{

    Console.WriteLine(i);

    suma += i;

}
Console.WriteLine($"suma liczb dodatnich z listy: {suma}");