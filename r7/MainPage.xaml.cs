namespace r7
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRGBChanged(object sender, EventArgs e)
        {
            int Rcolor = Convert.ToInt32(R.Value);
            int Gcolor = Convert.ToInt32(G.Value);
            int Bcolor = Convert.ToInt32(B.Value);

            if(Rcolor < 100 || Gcolor < 100 || Bcolor < 100)
            {
                Color16x.TextColor = Colors.White;
            }
            else Color16x.TextColor = Colors.Black;

            Page.BackgroundColor = Color.FromRgb(Rcolor, Gcolor, Bcolor);

            Color16x.Text = "Aktualny kolor: #" + Rcolor.ToString("X2") + Gcolor.ToString("X2") + Bcolor.ToString("X2");
        }
    }
}
