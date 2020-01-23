using System;
using ThemingDemo.Infrastructure;
using ThemingDemo.Services;
using Xamarin.Forms;

namespace ThemingDemo
{
    public partial class UserSummaryPage : ContentPage
    {
        public UserSummaryPage(IImageService imageService)
        {
            InitializeComponent();
            MonkeyImage.Source = imageService.FromEmbeddedResource("monkey.png");
        }

        async void OnNavigationInvoked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(ServiceLocator.Resolve<UserDetailsPage>());
        }

        async void OnThemeToolbarItemClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new ThemeSelectionPage()));
        }
    }
}
