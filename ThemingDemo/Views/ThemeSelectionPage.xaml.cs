using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ThemingDemo
{
    public partial class ThemeSelectionPage : ContentPage, IModalPage
    {
        public ThemeSelectionPage()
        {
            InitializeComponent();
        }

        void OnPickerSelectionChanged(object sender, EventArgs e)
        {
            Picker picker = sender as Picker;
            Theme theme = (Theme)picker.SelectedItem;

            if (ThemeHelper.ChangeTheme(theme))
                statusLabel.Text = $"{theme.ToString()} theme loaded. Close this page.";
        }

        public async Task Dismiss()
        {
            await Navigation.PopModalAsync();
        }
    }
}
