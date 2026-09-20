using System;
using System.Net;

class dzial6_3
{




    static void Main()

    {

        int liczba;

        int wielkosc;

        int najwieksza = 0;

        int najmniejsza = 0;


        do
        {

            Console.WriteLine("podaj wielkość tworzonej tablicy");

            string wpis = Console.ReadLine();

            int.TryParse(wpis, out wielkosc);

        } while (wielkosc <= 0);

        int[] tablica = new int[wielkosc];

        for (int i = 0; i < tablica.Length; i++)

        {



            Console.WriteLine($"podaj {i + 1}. liczbę");

            string wpis = Console.ReadLine();

            int.TryParse(wpis, out liczba);

            tablica[i] = liczba;

        }

        for (int i = 0; i < tablica.Length; i++)

        {

            if (tablica[i] > najwieksza)

            {

                najwieksza = tablica[i];

            }

        }

        najmniejsza = tablica[0];

        for (int i = 0; i < tablica.Length; i++)

        {





            if (najmniejsza > tablica[i])

            {

                najmniejsza = tablica[i];


            }



        }

        Console.WriteLine($"największa liczba w tablicy to: {najwieksza} a najmniejsza to {najmniejsza}");

        int pomoc = 0;

        for (int i = 0; i < tablica.Length; i++)

        {



            for (int j = 0; j < tablica.Length - 1; j++)
            {

                if (tablica[j + 1] > tablica[j])

                {

                    pomoc = tablica[j + 1];

                    tablica[j + 1] = tablica[j];

                    tablica[j] = pomoc;

                }





            }



        }

        Console.WriteLine("ładnie posortowana tablica:");

        for (int i = 0; i < tablica.Length; i++)

        {

            Console.WriteLine(tablica[i]);

        }

    }

}