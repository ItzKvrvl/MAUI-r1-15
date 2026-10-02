namespace r12_INF04
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NumerOpuszczony(object sender, FocusEventArgs e)
        {
            string numer = poleNumer.Text;

            if (string.IsNullOrWhiteSpace(numer))
            {
                obrazZdjecie.Source = null;
                obrazOdcisk.Source = null;
                return;
            }

            obrazZdjecie.Source = "img_" + numer + "_zdjecie.jpg";
            obrazOdcisk.Source = "img_" + numer + "_odcisk.jpg";
        }
        private async void ZatwierdzDane(object sender, EventArgs e)
        {
            string imie = poleImie.Text;
            string nazwisko = poleNazwisko.Text;

            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko))
            {
                await DisplayAlert("Uwaga", "Wprowadz dane", "OK");
                return;
            }

            string kolorOczu = PobierzKolorOczu();
            string komunikat = imie + " " + nazwisko + " kolor oczu " + kolorOczu;

            await DisplayAlert("Dane paszportowe", komunikat, "OK");
        }

        //dodana funkcja
        private void Wyczysc(object sender, EventArgs e)
        {
            poleNumer.Text = string.Empty;
            poleImie.Text = string.Empty;
            poleNazwisko.Text = string.Empty;

            oczyNiebieskie.IsChecked = true;

            obrazZdjecie.IsVisible = false;
            obrazOdcisk.IsVisible = false;
        }

        private string PobierzKolorOczu()
        {
            if (oczyNiebieskie.IsChecked) return "niebieskie";
            if (oczyZielone.IsChecked) return "zielone";
            if (oczySzare.IsChecked) return "szare";
            return "piwne";
        }
    }
}
