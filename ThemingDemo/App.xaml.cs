using Xamarin.Forms;

namespace ThemingDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new UserSummaryPage());
#if Banana
            ThemeHelper.ChangeTheme(Theme.Dark);
#else
            ThemeHelper.ChangeTheme(Theme.Light);
#endif

           
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
