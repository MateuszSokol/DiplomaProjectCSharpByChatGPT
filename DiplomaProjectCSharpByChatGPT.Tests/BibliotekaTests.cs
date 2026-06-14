using System;
using Xunit;

public class BibliotekaTests
{
    [Fact]
    public void DodajKsiazke_PowinienDodacKsiazke()
    {
        // arrange
        var biblioteka = new Biblioteka();
        var ksiazka = new Ksiazka("Hobbit", "Tolkien", "123");

        // act
        biblioteka.DodajKsiazke(ksiazka);
        var wynik = biblioteka.WyszukajPoTytule("Hobbit");

        // assert
        Assert.NotNull(wynik);
        Assert.Equal("Hobbit", wynik.Tytul);
    }

    [Fact]
    public void UsunKsiazke_IstniejacaPowinnaZostacUsunieta()
    {
        // arrange
        var biblioteka = new Biblioteka();
        var ksiazka = new Ksiazka("Metro 2033", "Glukhovsky", "456");
        biblioteka.DodajKsiazke(ksiazka);

        // act
        var result = biblioteka.UsunKsiazke("456");

        // assert
        Assert.True(result);
        Assert.Null(biblioteka.WyszukajPoTytule("Metro 2033"));
    }

    [Fact]
    public void UsunKsiazke_NieistniejacaPowinnaZwracacFalse()
    {
        // arrange
        var biblioteka = new Biblioteka();

        // act
        var result = biblioteka.UsunKsiazke("BRAK");

        // assert
        Assert.False(result);
    }

    [Fact]
    public void WyszukajPoTytule_NieCzułeNaWielkoscLiter()
    {
        // arrange
        var biblioteka = new Biblioteka();
        biblioteka.DodajKsiazke(new Ksiazka("Wiedźmin", "Sapkowski", "789"));

        // act
        var wynik = biblioteka.WyszukajPoTytule("wIeDźMiN");

        // assert
        Assert.NotNull(wynik);
        Assert.Equal("Wiedźmin", wynik.Tytul);
    }
}