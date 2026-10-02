namespace r4
{
    public partial class MainPage : ContentPage
    {
        // r4 z2-3
        public MainPage()
        {
            InitializeComponent();
        }

        //funkcja zrobiona z ai zeby nie sprawdzac zaznaczenia kazdego radiobuttona osobnym if'em
        private string wybranaFormaKursu = string.Empty;
        private void OnKursFormaChanged(object sender, CheckedChangedEventArgs e)
        {
            // Sprawdzamy, czy zdarzenie dotyczy zaznaczenia (e.Value == true)
            if (sender is RadioButton radioButton && e.Value)
            {
                wybranaFormaKursu = radioButton.Content.ToString();
            }
        }

        private void OnClicked(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name.Text))
            {
                DisplayAlertAsync("Blad", "Podaj imię i nazwisko", "ok");
            }
            else
            {
                string BoxCheck;
                string Switchbtn;
                if (Check.IsChecked == true)
                {
                    BoxCheck = "Posiadana";
                }
                else BoxCheck = "brak";

                if (SwitchCertify.IsToggled == true)
                {
                    Switchbtn = "Tak";
                }
                else Switchbtn = "Nie";
                DisplayAlertAsync("podsumowanie", $"Dane osobowe: {Name.Text}. \n" +
                    $" Posiadana wiedza?: {BoxCheck}. \n" +
                    $" dodatkowy certyfikat?: {Switchbtn}. \n" +
                    $" Forma kursu {wybranaFormaKursu}. \n" +
                    $"oczekiwania: {poleOpis.Text}", "ok");
            }
        }
    }
}
