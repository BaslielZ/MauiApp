namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSayHelloClicked(object sender, EventArgs e)
        {
            string name = MyName.Text;
            MyLabel.Text = $"Hello, {name}.";
        }
    }
}
