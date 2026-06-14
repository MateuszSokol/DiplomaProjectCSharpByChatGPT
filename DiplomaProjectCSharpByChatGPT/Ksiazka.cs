public class Ksiazka
{
    public string Tytul { get; private set; }
    public string Autor { get; private set; }
    public string ISBN { get; private set; }

    public Ksiazka(string tytul, string autor, string isbn)
    {
        Tytul = tytul;
        Autor = autor;
        ISBN = isbn;
    }

    public override string ToString()
    {
        return $"Tytuł: {Tytul}, Autor: {Autor}, ISBN: {ISBN}";
    }
}