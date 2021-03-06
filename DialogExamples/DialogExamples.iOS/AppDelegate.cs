using CoreGraphics;
using Foundation;
using UIKit;
using MvvmCross.Platform;
using MvvmCross.iOS.Platform;
using MvvmCross.Core.ViewModels;

namespace DialogExamples.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxApplicationDelegate
    {
        UIWindow _window;

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            _window = new UIWindow((CGRect)UIScreen.MainScreen.Bounds);

            var setup = new Setup(this, _window);
            setup.Initialize();

            var startup = Mvx.Resolve<IMvxAppStart>();
            startup.Start();

            _window.MakeKeyAndVisible();

            return true;
        }
    }
}