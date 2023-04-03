using ObjCRuntime;

namespace Drastic.Chameleon
{
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
		TopToBottom,
		Diagonal
	}

	[Native]
	public enum UIShadeStyle : long
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
}
