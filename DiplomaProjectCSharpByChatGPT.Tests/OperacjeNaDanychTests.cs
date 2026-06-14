using System.Collections.Generic;
using Xunit;

public class OperacjeNaDanychTests
{
    private OperacjeNaDanych PrzygotujDane()
    {
        var o = new OperacjeNaDanych();

        o.DodajProdukt(new Produkt("Laptop", "Elektronika", 3000m));
        o.DodajProdukt(new Produkt("Mysz", "Elektronika", 100m));
        o.DodajProdukt(new Produkt("Jabłko", "Spożywcze", 5m));
        o.DodajProdukt(new Produkt("Banan", "Spożywcze", 3m));

        return o;
    }

    [Fact]
    public void SortujPoCenie_PowinnoSortowacRosnaco()
    {
        // arrange
        var o = PrzygotujDane();

        // act
        var wynik = o.SortujPoCenie();

        // assert
        Assert.Equal(3m, wynik[0].Cena);
        Assert.Equal(5m, wynik[1].Cena);
        Assert.Equal(100m, wynik[2].Cena);
        Assert.Equal(3000m, wynik[3].Cena);
    }

    [Fact]
    public void FiltrujPoKategorii_PowinnoZwracacTylkoPasujace()
    {
        // arrange
        var o = PrzygotujDane();

        // act
        var wynik = o.FiltrujPoKategorii("Elektronika");

        // assert
        Assert.Equal(2, wynik.Count);
        Assert.All(wynik, p => Assert.Equal("Elektronika", p.Kategoria, ignoreCase: true));
    }

    [Fact]
    public void FiltrujPoKategorii_NieCzułeNaWielkoscLiter()
    {
        // arrange
        var o = PrzygotujDane();

        // act
        var wynik = o.FiltrujPoKategorii("spożywcze");

        // assert
        Assert.Equal(2, wynik.Count);
    }

    [Fact]
    public void WyszukajPoNazwie_PowinienZnalezcProdukt()
    {
        // arrange
        var o = PrzygotujDane();

        // act
        var wynik = o.WyszukajPoNazwie("laptop");

        // assert
        Assert.NotNull(wynik);
        Assert.Equal("Laptop", wynik.Nazwa);
    }

    [Fact]
    public void WyszukajPoNazwie_NieIstniejacyZwracaNull()
    {
        // arrange
        var o = PrzygotujDane();

        // act
        var wynik = o.WyszukajPoNazwie("telewizor");

        // assert
        Assert.Null(wynik);
    }

    [Fact]
    public void DodawanieProduktow_PowinnoUmozliwiacPraceNaDanych()
    {
        // arrange
        var o = new OperacjeNaDanych();

        // act
        o.DodajProdukt(new Produkt("A", "X", 10m));
        o.DodajProdukt(new Produkt("B", "X", 20m));

        var sorted = o.SortujPoCenie();

        // assert
        Assert.Equal(2, sorted.Count);
        Assert.Equal("A", sorted[0].Nazwa);
    }
}