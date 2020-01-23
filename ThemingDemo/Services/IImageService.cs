using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ThemingDemo.Services
{
    public interface IImageService
    {
        ImageSource FromEmbeddedResource(string sourceName);
    }
}
