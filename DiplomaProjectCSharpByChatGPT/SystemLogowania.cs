public class SystemLogowania
{
    private Uzytkownik uzytkownik;

    public SystemLogowania(Uzytkownik uzytkownik)
    {
        this.uzytkownik = uzytkownik;
    }

    public bool Zaloguj(string login, string haslo)
    {
        if (uzytkownik.Login == login && uzytkownik.SprawdzHaslo(haslo))
        {
            Console.WriteLine("Logowanie zakończone sukcesem.");
            return true;
        }

        Console.WriteLine("Błędny login lub hasło.");
        return false;
    }
}