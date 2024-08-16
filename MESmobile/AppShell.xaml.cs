namespace MESmobile
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            // Navigate back to the LoginPage
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
