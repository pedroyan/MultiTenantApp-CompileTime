using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ThemingDemo.Services
{

    public abstract class BrandImageService : IImageService
    {
        protected BrandImageService(string brandFolder)
        {
            BrandFolder = brandFolder;
        }

        public string BrandFolder { get; }
        private string PathToResource => $"ThemingDemo.Images.{BrandFolder}";
        public virtual ImageSource FromFile(string sourceName)
        {
            return ImageSource.FromResource($"{PathToResource}.{sourceName}");
        }
    }

    public class BananaImageService : BrandImageService
    {
        public BananaImageService() : base("Banana")
        {
        }
    }

    public class MonkeyImageService : BrandImageService
    {
        public MonkeyImageService() : base("Monkey")
        {
        }
    }
}
