namespace r6
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterButtonClicked(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if(clickedButton == PlusBtn)
            {
                count++;
            }
            else if(clickedButton == MinusBtn)
            {
                if(count > 0)
                {
                    count--;
                }
            }
            UpdateLabel();
        }

        private void ResetBtn_Clicked(object sender, EventArgs e)
        {
            count = 0;
            UpdateLabel();
        }
        private void UpdateLabel()
        {
            NumberLabel.Text = "Biezaca liczba: " + count.ToString();
        }

    }
}
