using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ThemingDemo
{
    public static class ThemeHelper
    {
        public static bool ChangeTheme(Theme theme)
        {
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();

                switch (theme)
                {
                    case Theme.Dark:
                        mergedDictionaries.Add(new DarkTheme());
                        return true;
                    case Theme.Light:
                    default:
                        mergedDictionaries.Add(new LightTheme());
                        return true;
                }
            }

            return false;
        }
    }
}
