using Xunit;

public class KsiazkaTests
{
    [Fact]
    public void Ksiazka_PowinnaPoprawnieUstawicWartosci()
    {
        // act
        var ksiazka = new Ksiazka("Dune", "Frank Herbert", "999");

        // assert
        Assert.Equal("Dune", ksiazka.Tytul);
        Assert.Equal("Frank Herbert", ksiazka.Autor);
        Assert.Equal("999", ksiazka.ISBN);
    }

    [Fact]
    public void ToString_PowinienZawieracDaneKsiazki()
    {
        // arrange
        var ksiazka = new Ksiazka("Dune", "Frank Herbert", "999");

        // act
        var tekst = ksiazka.ToString();

        // assert
        Assert.Contains("Dune", tekst);
        Assert.Contains("Frank Herbert", tekst);
        Assert.Contains("999", tekst);
    }
}