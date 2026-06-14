using Xunit;

public class KontoBankoweTests
{
    [Fact]
    public void Konstruktor_PowinienPoprawnieUstawicDane()
    {
        // arrange & act
        var konto = new KontoBankowe("123", "Jan Kowalski", 100m);

        // assert
        Assert.Equal("123", konto.NumerKonta);
        Assert.Equal("Jan Kowalski", konto.Wlasciciel);
        Assert.Equal(100m, konto.Saldo);
    }

    [Fact]
    public void Wplata_DodatniaKwota_PowinnaZwiekszycSaldo()
    {
        // arrange
        var konto = new KontoBankowe("1", "Jan", 100m);

        // act
        konto.Wplata(50m);

        // assert
        Assert.Equal(150m, konto.Saldo);
    }

    [Fact]
    public void Wplata_ZerowaLubUjemna_NieZmieniaSalda()
    {
        // arrange
        var konto = new KontoBankowe("1", "Jan", 100m);

        // act
        konto.Wplata(0m);
        konto.Wplata(-10m);

        // assert
        Assert.Equal(100m, konto.Saldo);
    }

    [Fact]
    public void Wyplata_WystarczajaceSrodki_PowinnaZmniejszycSaldoIZwrocicTrue()
    {
        // arrange
        var konto = new KontoBankowe("1", "Jan", 100m);

        // act
        var result = konto.Wyplata(40m);

        // assert
        Assert.True(result);
        Assert.Equal(60m, konto.Saldo);
    }

    [Fact]
    public void Wyplata_NiewystarczajaceSrodki_NieZmieniaSaldaIZwracaFalse()
    {
        // arrange
        var konto = new KontoBankowe("1", "Jan", 100m);

        // act
        var result = konto.Wyplata(200m);

        // assert
        Assert.False(result);
        Assert.Equal(100m, konto.Saldo);
    }

    [Fact]
    public void Wyplata_ZerowaLubUjemna_NieZmieniaSaldaIZwracaFalse()
    {
        // arrange
        var konto = new KontoBankowe("1", "Jan", 100m);

        // act
        var result1 = konto.Wyplata(0m);
        var result2 = konto.Wyplata(-50m);

        // assert
        Assert.False(result1);
        Assert.False(result2);
        Assert.Equal(100m, konto.Saldo);
    }

    [Fact]
    public void Operacje_KolejneTransakcjePowinnyDzialacPoprawnie()
    {
        // arrange
        var konto = new KontoBankowe("1", "Jan", 100m);

        // act
        konto.Wplata(50m);   // 150
        konto.Wyplata(20m);  // 130
        konto.Wplata(10m);   // 140

        // assert
        Assert.Equal(140m, konto.Saldo);
    }
}