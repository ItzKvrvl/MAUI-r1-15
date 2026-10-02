namespace r5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            DateChosen.MinimumDate = DateTime.Now;
        }

        private void OnClicked(object? sender, EventArgs e)
        {
            if (listaSal.SelectedIndex == -1)
            {
                lblKomunikat.Text = "Wybierz salę";
            }
            else
            {
                lblKomunikat.Text = $"Podsumowanie rezerwacji:\n" +
                                    $"Sala: {wybranasala}\n" +
                                    $"Liczba osób: {stepperIlosc.Value}\n" +
                                    $"Data: {DateChosen.Date:dd.MM.yyyy}";
            }
        }

        private void stepperIlosc_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int ilosc = (int)stepperIlosc.Value;
            Ilosc.Text = "Ilosc: " + ilosc;
        }

        string wybranasala;
        private void listaSal_SelectedIndexChanged(object sender, EventArgs e)
        {
            wybranasala = listaSal.SelectedItem?.ToString();
        }
    }
}
