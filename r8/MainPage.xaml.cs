namespace r8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Count_Clicked(object sender, EventArgs e)
        {
            bool CzySzerokoscPoprawna = double.TryParse(Szerokosc.Text, out double szerokosc);
            bool CzyWysokoscPoprawna = double.TryParse(Wysokosc.Text, out double  wysokosc);

            double Pole = 0;

            if(CzySzerokoscPoprawna && CzyWysokoscPoprawna && szerokosc > 0 && wysokosc > 0)
            {
                Pole = szerokosc * wysokosc;
                RectangleArea.Text = "Pole prostokata: " + Pole;
            }
            else
            {
                RectangleArea.Text = "Pole prostokata: 0";
                DisplayAlert("blad", "Podane wartosci sa bledne!", "ok");
            }
        }

        private async void Clear_Clicked(object sender, EventArgs e)
        {
            bool odpowiedz = await DisplayAlert("Potwierdzenie", "Czy chcesz wyczyścić dane?", "Tak", "Nie");

            if (odpowiedz)
            {
                Szerokosc.Text = string.Empty;
                Wysokosc.Text = string.Empty;
                RectangleArea.Text = "Pole prostokata: 0";
            }
        }
    }
}
