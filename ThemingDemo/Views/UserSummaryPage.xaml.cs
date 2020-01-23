﻿using System;
using ThemingDemo.Infrastructure;
using ThemingDemo.Services;
using Xamarin.Forms;

namespace ThemingDemo
{
    public partial class UserSummaryPage : ContentPage
    {
        public UserSummaryPage()
        {
            InitializeComponent();
        }

        async void OnNavigationInvoked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserDetailsPage(ServiceLocator.Resolve<IImageService>()));
        }

        async void OnThemeToolbarItemClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new ThemeSelectionPage()));
        }
    }
}
