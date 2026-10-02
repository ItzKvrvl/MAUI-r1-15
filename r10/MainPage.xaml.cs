namespace r10
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int RGB = (int)suwak.Value;
            this.BackgroundColor = Color.FromRgb(RGB, RGB, RGB);
        }
    }
}
