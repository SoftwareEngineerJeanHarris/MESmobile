using System;
using Microsoft.Maui.Controls;

namespace MESmobile.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Sample validation: check if the username entry is not empty
            if (!string.IsNullOrWhiteSpace(UsernameEntry.Text))
            {
                // Navigate to the HomePage
                await Shell.Current.GoToAsync("//HomePage");
            }
            else
            {
                await DisplayAlert("Error", "Please enter a username.", "OK");
            }
        }
    }
}
