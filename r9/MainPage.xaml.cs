using System.Collections.ObjectModel;

namespace r9
{
    public partial class MainPage : ContentPage
    {

        //ZADANIE 9.2 + 9.3

        int AktualnaLiczbaZakupow = 0;
        public MainPage()
        {
            InitializeComponent();
            WidokListy.ItemsSource = Zakupy;
        }

        ObservableCollection<string> Zakupy = new ObservableCollection<string>();

        public void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NowyProdukt.Text))
            {
                Zakupy.Add(NowyProdukt.Text);
                NowyProdukt.Text = string.Empty;
                AktualnaLiczbaZakupow++;
                PokazAktualneZakupy();
            }
        }

        private void DeleteClicked(object sender, EventArgs e)
        {
            if(WidokListy.SelectedItem == null)
            {
                return;
            }

            string zaznaczone = (string)WidokListy.SelectedItem;
            Zakupy.Remove(zaznaczone);

            if (AktualnaLiczbaZakupow > 0) AktualnaLiczbaZakupow--;
            PokazAktualneZakupy();
        }

        private void PokazAktualneZakupy()
        {
            LiczbaZakupow.Text = "Aktualna liczba zakupow: " + AktualnaLiczbaZakupow;
        }
    }
}
