using Foundation;
using ChameleonFramework;
using UIKit;
using ObjCRuntime;

namespace Drastic.ChameleonSampleMaui;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    static readonly NativeHandle class_ptr = Class.GetHandle("UIColor");
    public override bool WillFinishLaunching(UIApplication application, NSDictionary launchOptions)
    {
        return base.WillFinishLaunching(application, launchOptions);
    }

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        return base.FinishedLaunching(application, launchOptions);
    }
}
