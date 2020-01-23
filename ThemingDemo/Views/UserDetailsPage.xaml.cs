using System;
using ThemingDemo.Services;
using Xamarin.Forms;

namespace ThemingDemo
{
    public partial class UserDetailsPage : ContentPage
    {
        public UserDetailsPage(IImageService imageService)
        {
            InitializeComponent();
            FacePalmImage.Source = imageService.FromFile("FacePalm.png");
        }

        async void OnThemeToolbarItemClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new ThemeSelectionPage()));
        }
    }
}
