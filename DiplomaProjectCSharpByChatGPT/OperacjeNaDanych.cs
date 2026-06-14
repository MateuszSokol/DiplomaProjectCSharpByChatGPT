using System;
using System.Collections.Generic;
using System.Linq;

public class OperacjeNaDanych
{
    private List<Produkt> produkty = new List<Produkt>();

    public void DodajProdukt(Produkt produkt)
    {
        produkty.Add(produkt);
    }

    // SORTOWANIE po cenie rosnąco
    public List<Produkt> SortujPoCenie()
    {
        return produkty
            .OrderBy(p => p.Cena)
            .ToList();
    }

    // FILTROWANIE po kategorii
    public List<Produkt> FiltrujPoKategorii(string kategoria)
    {
        return produkty
            .Where(p => p.Kategoria.Equals(kategoria, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    // WYSZUKIWANIE po nazwie
    public Produkt WyszukajPoNazwie(string nazwa)
    {
        return produkty
            .FirstOrDefault(p => p.Nazwa.Equals(nazwa, StringComparison.OrdinalIgnoreCase));
    }

    public void WyswietlListe(List<Produkt> lista)
    {
        foreach (var produkt in lista)
        {
            Console.WriteLine(produkt);
        }
    }
}