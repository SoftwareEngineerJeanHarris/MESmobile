namespace MESmobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            //Shell.Current.GoToAsync("//LoginPage");
        }

        protected override void OnStart()
        {
            base.OnStart();

            // Navigate to the LoginPage when the app starts
            Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
