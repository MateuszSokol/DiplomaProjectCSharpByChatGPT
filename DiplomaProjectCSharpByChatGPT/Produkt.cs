public class Produkt
{
    public string Nazwa { get; private set; }
    public string Kategoria { get; private set; }
    public decimal Cena { get; private set; }

    public Produkt(string nazwa, string kategoria, decimal cena)
    {
        Nazwa = nazwa;
        Kategoria = kategoria;
        Cena = cena;
    }

    public override string ToString()
    {
        return $"Produkt: {Nazwa}, Kategoria: {Kategoria}, Cena: {Cena:C}";
    }
}