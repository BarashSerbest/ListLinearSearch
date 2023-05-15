using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Dizinin boyutu ve elemanları kullanıcıdan istenecek
        Console.Write("Dizinin boyutunu girin: ");
        int boyut = int.Parse(Console.ReadLine());

        var dizi = new List<int>();

        Console.WriteLine("Dizinin elemanlarını girin:");
        for (int i = 0; i < boyut; i++)
        {
            Console.Write($"{i + 1}. Eleman: ");
            int eleman = int.Parse(Console.ReadLine());
            dizi.Add(eleman);
        }

        // Dizide aranacak olan elemanı kullanıcıdan alma
        Console.Write("Aranacak elemanı girin: ");
        int arananEleman = int.Parse(Console.ReadLine());

        // Aranılan elemanın dizide olup olmadığını Linear Search fonksiyonu ile bulma 
        bool sonuc = LinearSearch(dizi, arananEleman);

        if (sonuc)
            Console.WriteLine($"Dizi içerisinde aradığınız eleman bulundu. Girdiginiz eleman: {arananEleman}");
        else
            Console.WriteLine($"Dizi içerisinde aradığınız eleman bulunamadı. Girdiginiz eleman: {arananEleman}");

        Console.ReadLine();
    }
    // Linear Search metodu ile arama yapma fonksiyonu 
    static bool LinearSearch(List<int> dizi, int arananEleman)
    {
        for (int i = 0; i < dizi.Count; i++)
        {
            if (dizi[i] == arananEleman)
                return true;
        }

        return false;
    }
}
