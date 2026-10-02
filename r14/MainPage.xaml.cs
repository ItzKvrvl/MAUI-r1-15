namespace r14
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int WidthInt = (int)this.Width;
            int HeightInt = (int)this.Height;

            Size.Text = $"Szerokość: {WidthInt}, Wysokość: {HeightInt}";
        }
    }
}
