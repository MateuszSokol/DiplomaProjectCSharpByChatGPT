public class KontoBankowe
{
    public string NumerKonta { get; private set; }
    public string Wlasciciel { get; private set; }
    public decimal Saldo { get; private set; }

    public KontoBankowe(string numerKonta, string wlasciciel, decimal saldoPoczatkowe)
    {
        NumerKonta = numerKonta;
        Wlasciciel = wlasciciel;
        Saldo = saldoPoczatkowe;
    }

    public void Wplata(decimal kwota)
    {
        if (kwota <= 0)
        {
            Console.WriteLine("Kwota wpłaty musi być większa od zera.");
            return;
        }

        Saldo += kwota;
        Console.WriteLine($"Wpłacono {kwota:C}. Aktualne saldo: {Saldo:C}");
    }

    public bool Wyplata(decimal kwota)
    {
        if (kwota <= 0)
        {
            Console.WriteLine("Kwota wypłaty musi być większa od zera.");
            return false;
        }

        if (kwota > Saldo)
        {
            Console.WriteLine("Brak wystarczających środków na koncie.");
            return false;
        }

        Saldo -= kwota;
        Console.WriteLine($"Wypłacono {kwota:C}. Aktualne saldo: {Saldo:C}");
        return true;
    }

    public void WyswietlSaldo()
    {
        Console.WriteLine($"Aktualne saldo: {Saldo:C}");
    }
}