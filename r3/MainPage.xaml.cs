namespace r3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Clear_Clicked(object sender, EventArgs e)
        {
            Tel.Text = string.Empty;
            Mail.Text = string.Empty;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Nazwa.Text) || string.IsNullOrWhiteSpace(Ilosc.Text) || string.IsNullOrWhiteSpace(Adres.Text))
            {
                DisplayAlert("Blad","Wypelnij wszystkie pola!","ok");
            }
            else
            {
                DisplayAlert("Podsumowanie zamowienia", $"Produkt: {Nazwa.Text}, ilość: {Ilosc.Text}, adres: {Adres.Text}", "ok");
            }
        }
    }
}
