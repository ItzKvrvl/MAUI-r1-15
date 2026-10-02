namespace r13_INF04
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SprawdzCene(object sender, EventArgs e)
        {
            if (poleP.IsChecked)
            {
                obrazPrzesylki.Source = "pocztowka.png";
                etykietaCena.Text = "Cena: 1 zl";
            }

            else if (poleL.IsChecked)
            {
                obrazPrzesylki.Source = "list.png";
                etykietaCena.Text = "Cena: 1,5 zl";
            }

            else if (poleK.IsChecked)
            {
                obrazPrzesylki.Source = "paczka.png";
                etykietaCena.Text = "Cena: 10 zl";
            }
        }

        private async void ZatwierdzPrzesylke(object sender, EventArgs e)
        {
            //dodana walidacja
            if (string.IsNullOrEmpty(poleUlica.Text))
            {
                await DisplayAlert("Walidacja", "Uzupelnij adres", "OK");
                return;
            }
            if (string.IsNullOrEmpty(poleMiasto.Text))
            {
                await DisplayAlert("Walidacja", "Uzupelnij adres", "OK");
                return;
            }

            string kod = poleKod.Text;

            if (string.IsNullOrEmpty(kod) || kod.Length != 5)
            {
                await DisplayAlert("Walidacja", "Nieprawidlowa liczba cyfr w kodzie pocztowym", "OK");
                return;
            }

            if (!CzySameCyfry(kod))
            {
                await DisplayAlert("Walidacja", "Kod pocztowy powinien sie skladac z samych cyfr", "OK");
                return;
            }

            await DisplayAlert("Sukces", "Dane przesylki zostaly wprowadzone", "OK");

        }

        private bool CzySameCyfry(string tekst)
        {
            foreach (char znak in tekst)
            {
                if (!char.IsDigit(znak))
                    return false;
            }
            return true;
        }
    }
}