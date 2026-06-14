using Xunit;

public class SystemLogowaniaTests
{
    [Fact]
    public void Zaloguj_PoprawneDane_ZwracaTrue()
    {
        // arrange
        var uzytkownik = new Uzytkownik("admin", "1234");
        var system = new SystemLogowania(uzytkownik);

        // act
        var result = system.Zaloguj("admin", "1234");

        // assert
        Assert.True(result);
    }

    [Fact]
    public void Zaloguj_BlednyLogin_ZwracaFalse()
    {
        // arrange
        var uzytkownik = new Uzytkownik("admin", "1234");
        var system = new SystemLogowania(uzytkownik);

        // act
        var result = system.Zaloguj("user", "1234");

        // assert
        Assert.False(result);
    }

    [Fact]
    public void Zaloguj_BledneHaslo_ZwracaFalse()
    {
        // arrange
        var uzytkownik = new Uzytkownik("admin", "1234");
        var system = new SystemLogowania(uzytkownik);

        // act
        var result = system.Zaloguj("admin", "wrong");

        // assert
        Assert.False(result);
    }

    [Fact]
    public void Zaloguj_CaseSensitiveLogin_PowinienBycWrazliwyNaWielkoscLiter()
    {
        // arrange
        var uzytkownik = new Uzytkownik("Admin", "1234");
        var system = new SystemLogowania(uzytkownik);

        // act
        var result = system.Zaloguj("admin", "1234");

        // assert
        Assert.False(result);
    }
}