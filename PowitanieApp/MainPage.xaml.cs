namespace PowitanieApp
{
    public partial class MainPage : ContentPage
    {
        //r1 z2-3
        int count = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClicked(object? sender, EventArgs e)
        {
            Label2.Text = "Aplikacja działa poprawnie";
        }

        private void OnResetClicked(object? sender, EventArgs e)
        {
            Label2.Text = "Witamy w aplikacji";
            count++;
            LabelCounter.Text = "Liczba klikniec: " + count;
        }
    }
}
