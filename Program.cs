using System;
using System.Runtime.InteropServices;

//Napisz program, który w 10-elementowej tablicy jednowymiarowej o nazwie tablica1 umieszcza liczby z przedziału od 0 do 9.

class TablicaJednowymiarowa
{
    static void Main(string[] args)
    {
        const int rozmiar_tablicy = 10;
        int[] tablica1 = new int[rozmiar_tablicy];

        Random rand = new Random();

        for (int i = 0; i < rozmiar_tablicy; i++)
        {
            tablica1[i] = rand.Next(10);
        }

        Console.WriteLine("Zawartość tablicy: ");
        foreach (int liczba in tablica1)
        {
            Console.WriteLine(liczba + " ");
        }
    }
}