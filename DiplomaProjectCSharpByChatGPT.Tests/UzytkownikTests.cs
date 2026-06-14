using Xunit;

public class UzytkownikTests
{
    [Fact]
    public void SprawdzHaslo_PoprawneHaslo_ZwracaTrue()
    {
        // arrange
        var u = new Uzytkownik("admin", "1234");

        // act
        var result = u.SprawdzHaslo("1234");

        // assert
        Assert.True(result);
    }

    [Fact]
    public void SprawdzHaslo_BledneHaslo_ZwracaFalse()
    {
        // arrange
        var u = new Uzytkownik("admin", "1234");

        // act
        var result = u.SprawdzHaslo("wrong");

        // assert
        Assert.False(result);
    }
}