namespace Melody.Service.SqlExecuters
{
  public class SqlExecute
  {
    private readonly string _logIn = "Exec LogIn";
    private readonly string _adresJakieMiasta = "Exec Adres_jakiemiasta";
    private readonly string _adresUsun = "Exec Adres_usun";
    private readonly string _adresWstaw = "Exec Adres_wstaw";
    private readonly string _adresZmian = "Exec Adres_zmien";
    private readonly string _daneKontaktoweUsun = "Exec DaneKontaktowe_usun";
    private readonly string _DaneKontaktoweWstaw = "Exec DaneKontaktowe_wstaw";
    private readonly string _DaneKontaktoweZmien = "Exec DaneKontaktowe_zmien";
    private readonly string _HotelUsun = "Exec Hotel_usun";
    private readonly string _HotelWstaw = "Exec Hotel_wstaw";
    private readonly string _HotelZmien = "Exec Hotel_zmien";
    private readonly string _KlientKompletDanych = "Exec Klient_komplet_danych";
    private readonly string _KlientUsun = "Exec Klient_usun";
    private readonly string _KlientWstaw = "Exec Klient_wstaw";
    private readonly string _klientWycieczkaOplacona = "Exec Klient_wycieczka_oplacona";
    private readonly string _klientZmien = "Exec Klient_zmien";
    private readonly string _kontrahentUsun = "Exec Kontrahent_usun";
    private readonly string _kontrahentWstaw = "Exec Kontrahent_wstaw";
    private readonly string _kontrahentZmien = "Exec Kontrahent_zmien";
    private readonly string _rezerwacjaPrzypomnienieNieopłacona = "Exec Rezerwacja_przypomnienie_nieopłacona";
    private readonly string _rezerwacjaUsun = "Exec Rezerwacja_usun";
    private readonly string _rezerwacjaWstaw = "Exec Rezerwacja_wstaw";
    private readonly string _rezerwacjaZmien = "Exec Rezerwacja_zmien";
    private readonly string _turnusUsun = "Exec Turnus_usun";
    private readonly string _turnusWstaw = "Exec Turnus_wstaw";
    private readonly string _turnusZmien = "Exec Turnus_zmien";
    private readonly string _wycieczkaTransport = "Exec Wycieczka_transport";
    private readonly string _wycieczkaUsun = "Exec Wycieczka_usun";
    private readonly string _wycieczkaWgKraju = "Exec Wycieczka_wg_kraju";
    private readonly string _wycieczkaWstaw = "Exec Wycieczka_wstaw";

    public string LogIn { get => _logIn; }

    public string Adres_jakiemiasta { get => _adresJakieMiasta; }

    public string Adres_usun { get => _adresUsun; }

    public string Adres_wstaw { get => _adresWstaw; }

    public string Adres_zmien { get => _adresZmian; }

    public string DaneKontaktowe_usun { get => _daneKontaktoweUsun; }

    public string DaneKontaktowe_wstaw { get => _DaneKontaktoweWstaw; }

    public string DaneKontaktowe_zmien { get => _DaneKontaktoweZmien; }

    public string Hotel_usun { get => _HotelUsun; }

    public string Hotel_wstaw { get => _HotelWstaw; }

    public string Hotel_zmien { get => _HotelZmien; }

    public string Klient_komplet_danych { get => _KlientKompletDanych; }

    public string Klient_usun { get => _KlientUsun; }

    public string Klient_wstaw { get => _KlientWstaw; }

    public string Klient_wycieczka_oplacona { get => _klientWycieczkaOplacona; }

    public string Klient_zmien { get => _klientZmien; }

    public string Kontrahent_usun { get => _kontrahentUsun; }

    public string Kontrahent_wstaw { get => _kontrahentWstaw; }

    public string Kontrahent_zmien { get => _kontrahentZmien; }

    public string Rezerwacja_przypomnienie_nieopłacona { get => _rezerwacjaPrzypomnienieNieopłacona; }

    public string Rezerwacja_usun { get => _rezerwacjaUsun; }

    public string Rezerwacja_wstaw { get => _rezerwacjaWstaw; }

    public string Rezerwacja_zmien { get => _rezerwacjaZmien; }

    public string Turnus_usun { get => _turnusUsun; }

    public string Turnus_wstaw { get => _turnusWstaw; }

    public string Turnus_zmien { get => _turnusZmien; }

    public string Wycieczka_transport { get => _wycieczkaTransport; }

    public string Wycieczka_usun { get => _wycieczkaUsun; }

    public string Wycieczka_wg_kraju { get => _wycieczkaWgKraju; }

    public string Wycieczka_wstaw { get => _wycieczkaWstaw; }
  }
}
