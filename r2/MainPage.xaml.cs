namespace r2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClicked(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EntryName.Text) || string.IsNullOrWhiteSpace(EntryCity.Text))
            {
                DisplayAlert("Blad", $"Uzupelnij oba pola!", "ok");
            }
            else
            {
                DisplayAlert("Ogloszenie", $"Witaj {EntryName.Text} z miasta {EntryCity.Text}", "ok");
            }
        }
    }
}
