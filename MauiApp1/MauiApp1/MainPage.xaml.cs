using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"{count} раз";
            else
                CounterBtn.Text = $"{count} - разів";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }


        private void OnButtonClicked(object sender, EventArgs e)
        {

            AccountPage accountPage = new AccountPage();
            Navigation.PushAsync(accountPage);
        }
    }
}

