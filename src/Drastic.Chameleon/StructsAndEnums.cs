#if IOS || MACCATALYST
using ObjCRuntime;
using UIKit;

namespace ChameleonFramework
{
	[Native]
	public enum ContentStyle : ulong
	{
		Contrast,
		Light,
		Dark
	}

	[Native]
	public enum GradientStyle : ulong
	{
		LeftToRight,
		Radial,
		TopToBottom
	}

	[Native]
	public enum ShadeStyle : long
	{
		Light,
		Dark
	}

	[Native]
	public enum ColorScheme : long
	{
		Analogous,
		Triadic,
		Complementary
	}

	public enum StatusBarStyle : long
	{
		BlackOpaque = UIStatusBarStyle.BlackOpaque,
		BlackTranslucent = UIStatusBarStyle.BlackTranslucent,
		Default = UIStatusBarStyle.Default,
		LightContent = UIStatusBarStyle.LightContent,

		Contrast = 100,
	}

    [Native]
    public enum UIContentStyle : ulong
    {
        Contrast,
        Light,
        Dark
    }

    [Native]
    public enum UIGradientStyle : ulong
    {
        LeftToRight,
        Radial,
        TopToBottom
    }

    [Native]
    public enum UIShadeStyle : long
    {
        Light,
        Dark
    }
}

#endif