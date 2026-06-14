public class Uzytkownik
{
    public string Login { get; private set; }
    private string Haslo;

    public Uzytkownik(string login, string haslo)
    {
        Login = login;
        Haslo = haslo;
    }

    public bool SprawdzHaslo(string haslo)
    {
        return Haslo == haslo;
    }
}