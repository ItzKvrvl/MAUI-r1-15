using System.Collections.ObjectModel;

namespace r11_INF04
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            AktualizujDuzyProstokat();
            WidokListy.ItemsSource = Kolorory;
        }
        
        ObservableCollection <string> Kolorory = new ObservableCollection<string>();

        private void SuwakZmieniony(object sender, ValueChangedEventArgs e)
        {
            AktualizujDuzyProstokat();
        }

        private void AktualizujDuzyProstokat()
        {
            int r = (int)suwakR.Value;
            int g = (int)suwakG.Value;
            int b = (int)suwakB.Value;

            etykietaR.Text = r.ToString();
            etykietaG.Text = g.ToString();
            etykietaB.Text = b.ToString();

            duzyProstokat.Color = Color.FromRgb(r, g, b);
        }

        private void PobierzKolor(object sender, EventArgs e)
        {
            int r = (int)suwakR.Value;
            int g = (int)suwakG.Value;
            int b = (int)suwakB.Value;

            Kolorory.Add("#" + r.ToString("X2") + g.ToString("X2") + b.ToString("X2"));

            if (etykietaPobrany.Parent is Border ramka)
            {
                ramka.BackgroundColor = Color.FromRgb(r, g, b);
            }

            etykietaPobrany.Text = r + ", " + g + ", " + b;
        }
    }
}