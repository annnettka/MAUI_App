using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class AccountPage : ContentPage
    {
        public AccountPage()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            // Створення нової сторінки для переходу
            AccountPage accountPage = new AccountPage();

            // Виклик методу Navigation для переходу на другу сторінку
            await Navigation.PushAsync(accountPage);
        }
    }
}