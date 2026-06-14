using System;
using System.Collections.Generic;
using System.Linq;

public class Biblioteka
{
    private List<Ksiazka> ksiazki = new List<Ksiazka>();

    public void DodajKsiazke(Ksiazka ksiazka)
    {
        ksiazki.Add(ksiazka);
        Console.WriteLine($"Dodano książkę: {ksiazka.Tytul}");
    }

    public bool UsunKsiazke(string isbn)
    {
        var ksiazka = ksiazki.FirstOrDefault(k => k.ISBN == isbn);

        if (ksiazka == null)
        {
            Console.WriteLine("Nie znaleziono książki o podanym ISBN.");
            return false;
        }

        ksiazki.Remove(ksiazka);
        Console.WriteLine($"Usunięto książkę: {ksiazka.Tytul}");
        return true;
    }

    public Ksiazka WyszukajPoTytule(string tytul)
    {
        return ksiazki.FirstOrDefault(k =>
            k.Tytul.Equals(tytul, StringComparison.OrdinalIgnoreCase));
    }

    public void WyswietlWszystkie()
    {
        if (ksiazki.Count == 0)
        {
            Console.WriteLine("Biblioteka jest pusta.");
            return;
        }

        Console.WriteLine("Lista książek:");
        foreach (var ksiazka in ksiazki)
        {
            Console.WriteLine(ksiazka);
        }
    }
}