using System;
using System.Collections.Generic;
using System.Text;
using ThemingDemo.Services;
using TinyIoC;

namespace ThemingDemo.Infrastructure
{
    public static class ServiceLocator
    {
        private static TinyIoCContainer _container;

        static ServiceLocator()
        {
            _container = new TinyIoCContainer();

            //Ideally I would break the application into an MVVM structure. But since this is only a POC project, I won't do that. Instead
            //I wiill resolve xaml pages directly just to prove a point
            _container.Register<UserDetailsPage>();

            // Services - by default, TinyIoC will register interface registrations as singletons.
#if Banana
            _container.Register<IImageService, BananaImageService>();
#else
            _container.Register<IImageService, MonkeyImageService>();
#endif
        }

        public static T Resolve<T>() where T : class
        {
            return _container.Resolve<T>();
        }
    }
}
