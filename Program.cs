﻿using System;

namespace diziler_array_sinifi_metodlari;

class Program
{
    static void Main(string[] args)
    {
        int[] sayiDizisi = {23,12,4,86,72,3,11,17};

        Console.WriteLine("***** Sırasız Dizi *****");
        foreach (int sayi in sayiDizisi)
            Console.WriteLine(sayi);

        // Sort
        Console.WriteLine("***** Sıralı Dizi *****");
        Array.Sort(sayiDizisi);

        foreach (int sayi in sayiDizisi)
            Console.WriteLine(sayi);
            
        // Clear
        Console.WriteLine("***** Array Clear *****");
        Array.Clear(sayiDizisi,2,2);

        foreach (int sayi in sayiDizisi)
            Console.WriteLine(sayi);

        // Reverse
        Console.WriteLine("***** Array Reverse *****");
        Array.Reverse(sayiDizisi);

        foreach (int sayi in sayiDizisi)
            Console.WriteLine(sayi);
                    
        // IndexOf
        Console.WriteLine("***** Array IndexOf *****");
        Console.WriteLine(Array.IndexOf(sayiDizisi,23));

        // Resize
        Console.WriteLine("***** Array Resize *****");
        Array.Resize<int>(ref sayiDizisi,9);
        sayiDizisi[8] = 99;

        foreach (int sayi in sayiDizisi)
            Console.WriteLine(sayi);
    }
}
