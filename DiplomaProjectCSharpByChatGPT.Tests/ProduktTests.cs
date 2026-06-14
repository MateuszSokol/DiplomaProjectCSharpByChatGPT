using Xunit;

public class ProduktTests
{
    [Fact]
    public void Konstruktor_PowinienUstawicWartosci()
    {
        // act
        var produkt = new Produkt("Laptop", "Elektronika", 3000m);

        // assert
        Assert.Equal("Laptop", produkt.Nazwa);
        Assert.Equal("Elektronika", produkt.Kategoria);
        Assert.Equal(3000m, produkt.Cena);
    }

    [Fact]
    public void ToString_PowinienZawieracDaneProduktu()
    {
        // arrange
        var produkt = new Produkt("Telefon", "Elektronika", 2000m);

        // act
        var tekst = produkt.ToString();

        // assert
        Assert.Contains("Telefon", tekst);
        Assert.Contains("Elektronika", tekst);
        Assert.Contains("2000", tekst);
    }
}