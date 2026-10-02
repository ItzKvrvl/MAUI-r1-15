using System.Globalization;

namespace r15
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Oblicz(object sender, EventArgs e)
        {
            if (!double.TryParse(poleKwota.Text, NumberStyles.Any,
              CultureInfo.InvariantCulture, out double kwota) || kwota < 0)
            {
                await DisplayAlert("Uwaga", "Wprowadz poprawna kwote", "OK");
                return;
            }

            if (!int.TryParse(poleOsob.Text, NumberStyles.Any,
              CultureInfo.InvariantCulture, out int LiczbaOsob) && LiczbaOsob < 1)
            {
                 await DisplayAlert("Uwaga", "Wprowadz poprawna liczbe osob", "OK");
                 return;
            }

            double procent = PobierzStawke();
            double napiwek = kwota * procent;
            double razem = kwota + napiwek;
            double NaOsobeCena = razem / LiczbaOsob;

            etykietaNapiwek.Text = "Napiwek: " + napiwek.ToString("F2") + " zl";
            etykietaRazem.Text = "Razem: " + razem.ToString("F2") + " zl";
            etykietaNaOsobte.Text = "Na osobe: " + NaOsobeCena.ToString("F2") + " zl";
        }

        private double PobierzStawke()
        {
            if (stawka15.IsChecked)
                return 0.15;

            if (stawka20.IsChecked)
                return 0.20;

            return 0.10;
        }

        private void Wyczysc(object sender, EventArgs e)
        {
            poleKwota.Text = string.Empty;
            stawka10.IsChecked = true;
            etykietaNapiwek.Text = "Napiwek: ";
            etykietaRazem.Text = "Razem: ";
        }
    }
}
