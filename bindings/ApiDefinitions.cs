using System;
using Chameleon;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Drastic.Chameleon
{
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double ChameleonVersionNumber;
		[Field ("ChameleonVersionNumber", "__Internal")]
		double ChameleonVersionNumber { get; }

		// extern const unsigned char[] ChameleonVersionString;
		[Field ("ChameleonVersionString", "__Internal")]
		byte[] ChameleonVersionString { get; }

		// extern const UIStatusBarStyle UIStatusBarStyleContrast;
		[Field ("UIStatusBarStyleContrast", "__Internal")]
		UIStatusBarStyle UIStatusBarStyleContrast { get; }
	}

	// @interface ChameleonConstants : NSObject
	[BaseType (typeof(NSObject))]
	interface ChameleonConstants
	{
	}

	// @interface Chameleon (UIColor)
	[Category]
	[BaseType (typeof(UIColor))]
	interface UIColor_Chameleon
	{
		// @property (nonatomic, strong) UIImage * _Nonnull gradientImage;
		[Export ("gradientImage", ArgumentSemantic.Strong)]
		UIImage GradientImage { get; set; }

		// +(UIColor * _Nonnull)flatBlackColor;
		[Static]
		[Export ("flatBlackColor")]
		[Verify (MethodToProperty)]
		UIColor FlatBlackColor { get; }

		// +(UIColor * _Nonnull)flatBlueColor;
		[Static]
		[Export ("flatBlueColor")]
		[Verify (MethodToProperty)]
		UIColor FlatBlueColor { get; }

		// +(UIColor * _Nonnull)flatBrownColor;
		[Static]
		[Export ("flatBrownColor")]
		[Verify (MethodToProperty)]
		UIColor FlatBrownColor { get; }

		// +(UIColor * _Nonnull)flatCoffeeColor;
		[Static]
		[Export ("flatCoffeeColor")]
		[Verify (MethodToProperty)]
		UIColor FlatCoffeeColor { get; }

		// +(UIColor * _Nonnull)flatForestGreenColor;
		[Static]
		[Export ("flatForestGreenColor")]
		[Verify (MethodToProperty)]
		UIColor FlatForestGreenColor { get; }

		// +(UIColor * _Nonnull)flatGrayColor;
		[Static]
		[Export ("flatGrayColor")]
		[Verify (MethodToProperty)]
		UIColor FlatGrayColor { get; }

		// +(UIColor * _Nonnull)flatGreenColor;
		[Static]
		[Export ("flatGreenColor")]
		[Verify (MethodToProperty)]
		UIColor FlatGreenColor { get; }

		// +(UIColor * _Nonnull)flatLimeColor;
		[Static]
		[Export ("flatLimeColor")]
		[Verify (MethodToProperty)]
		UIColor FlatLimeColor { get; }

		// +(UIColor * _Nonnull)flatMagentaColor;
		[Static]
		[Export ("flatMagentaColor")]
		[Verify (MethodToProperty)]
		UIColor FlatMagentaColor { get; }

		// +(UIColor * _Nonnull)flatMaroonColor;
		[Static]
		[Export ("flatMaroonColor")]
		[Verify (MethodToProperty)]
		UIColor FlatMaroonColor { get; }

		// +(UIColor * _Nonnull)flatMintColor;
		[Static]
		[Export ("flatMintColor")]
		[Verify (MethodToProperty)]
		UIColor FlatMintColor { get; }

		// +(UIColor * _Nonnull)flatNavyBlueColor;
		[Static]
		[Export ("flatNavyBlueColor")]
		[Verify (MethodToProperty)]
		UIColor FlatNavyBlueColor { get; }

		// +(UIColor * _Nonnull)flatOrangeColor;
		[Static]
		[Export ("flatOrangeColor")]
		[Verify (MethodToProperty)]
		UIColor FlatOrangeColor { get; }

		// +(UIColor * _Nonnull)flatPinkColor;
		[Static]
		[Export ("flatPinkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatPinkColor { get; }

		// +(UIColor * _Nonnull)flatPlumColor;
		[Static]
		[Export ("flatPlumColor")]
		[Verify (MethodToProperty)]
		UIColor FlatPlumColor { get; }

		// +(UIColor * _Nonnull)flatPowderBlueColor;
		[Static]
		[Export ("flatPowderBlueColor")]
		[Verify (MethodToProperty)]
		UIColor FlatPowderBlueColor { get; }

		// +(UIColor * _Nonnull)flatPurpleColor;
		[Static]
		[Export ("flatPurpleColor")]
		[Verify (MethodToProperty)]
		UIColor FlatPurpleColor { get; }

		// +(UIColor * _Nonnull)flatRedColor;
		[Static]
		[Export ("flatRedColor")]
		[Verify (MethodToProperty)]
		UIColor FlatRedColor { get; }

		// +(UIColor * _Nonnull)flatSandColor;
		[Static]
		[Export ("flatSandColor")]
		[Verify (MethodToProperty)]
		UIColor FlatSandColor { get; }

		// +(UIColor * _Nonnull)flatSkyBlueColor;
		[Static]
		[Export ("flatSkyBlueColor")]
		[Verify (MethodToProperty)]
		UIColor FlatSkyBlueColor { get; }

		// +(UIColor * _Nonnull)flatTealColor;
		[Static]
		[Export ("flatTealColor")]
		[Verify (MethodToProperty)]
		UIColor FlatTealColor { get; }

		// +(UIColor * _Nonnull)flatWatermelonColor;
		[Static]
		[Export ("flatWatermelonColor")]
		[Verify (MethodToProperty)]
		UIColor FlatWatermelonColor { get; }

		// +(UIColor * _Nonnull)flatWhiteColor;
		[Static]
		[Export ("flatWhiteColor")]
		[Verify (MethodToProperty)]
		UIColor FlatWhiteColor { get; }

		// +(UIColor * _Nonnull)flatYellowColor;
		[Static]
		[Export ("flatYellowColor")]
		[Verify (MethodToProperty)]
		UIColor FlatYellowColor { get; }

		// +(UIColor * _Nonnull)flatBlackDarkColor;
		[Static]
		[Export ("flatBlackDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatBlackDarkColor { get; }

		// +(UIColor * _Nonnull)flatBlueDarkColor;
		[Static]
		[Export ("flatBlueDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatBlueDarkColor { get; }

		// +(UIColor * _Nonnull)flatBrownDarkColor;
		[Static]
		[Export ("flatBrownDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatBrownDarkColor { get; }

		// +(UIColor * _Nonnull)flatCoffeeDarkColor;
		[Static]
		[Export ("flatCoffeeDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatCoffeeDarkColor { get; }

		// +(UIColor * _Nonnull)flatForestGreenDarkColor;
		[Static]
		[Export ("flatForestGreenDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatForestGreenDarkColor { get; }

		// +(UIColor * _Nonnull)flatGrayDarkColor;
		[Static]
		[Export ("flatGrayDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatGrayDarkColor { get; }

		// +(UIColor * _Nonnull)flatGreenDarkColor;
		[Static]
		[Export ("flatGreenDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatGreenDarkColor { get; }

		// +(UIColor * _Nonnull)flatLimeDarkColor;
		[Static]
		[Export ("flatLimeDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatLimeDarkColor { get; }

		// +(UIColor * _Nonnull)flatMagentaDarkColor;
		[Static]
		[Export ("flatMagentaDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatMagentaDarkColor { get; }

		// +(UIColor * _Nonnull)flatMaroonDarkColor;
		[Static]
		[Export ("flatMaroonDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatMaroonDarkColor { get; }

		// +(UIColor * _Nonnull)flatMintDarkColor;
		[Static]
		[Export ("flatMintDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatMintDarkColor { get; }

		// +(UIColor * _Nonnull)flatNavyBlueDarkColor;
		[Static]
		[Export ("flatNavyBlueDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatNavyBlueDarkColor { get; }

		// +(UIColor * _Nonnull)flatOrangeDarkColor;
		[Static]
		[Export ("flatOrangeDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatOrangeDarkColor { get; }

		// +(UIColor * _Nonnull)flatPinkDarkColor;
		[Static]
		[Export ("flatPinkDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatPinkDarkColor { get; }

		// +(UIColor * _Nonnull)flatPlumDarkColor;
		[Static]
		[Export ("flatPlumDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatPlumDarkColor { get; }

		// +(UIColor * _Nonnull)flatPowderBlueDarkColor;
		[Static]
		[Export ("flatPowderBlueDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatPowderBlueDarkColor { get; }

		// +(UIColor * _Nonnull)flatPurpleDarkColor;
		[Static]
		[Export ("flatPurpleDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatPurpleDarkColor { get; }

		// +(UIColor * _Nonnull)flatRedDarkColor;
		[Static]
		[Export ("flatRedDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatRedDarkColor { get; }

		// +(UIColor * _Nonnull)flatSandDarkColor;
		[Static]
		[Export ("flatSandDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatSandDarkColor { get; }

		// +(UIColor * _Nonnull)flatSkyBlueDarkColor;
		[Static]
		[Export ("flatSkyBlueDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatSkyBlueDarkColor { get; }

		// +(UIColor * _Nonnull)flatTealDarkColor;
		[Static]
		[Export ("flatTealDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatTealDarkColor { get; }

		// +(UIColor * _Nonnull)flatWatermelonDarkColor;
		[Static]
		[Export ("flatWatermelonDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatWatermelonDarkColor { get; }

		// +(UIColor * _Nonnull)flatWhiteDarkColor;
		[Static]
		[Export ("flatWhiteDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatWhiteDarkColor { get; }

		// +(UIColor * _Nonnull)flatYellowDarkColor;
		[Static]
		[Export ("flatYellowDarkColor")]
		[Verify (MethodToProperty)]
		UIColor FlatYellowDarkColor { get; }

		// +(UIColor * _Nonnull)randomFlatColor;
		[Static]
		[Export ("randomFlatColor")]
		[Verify (MethodToProperty)]
		UIColor RandomFlatColor { get; }

		// +(UIColor * _Nonnull)colorWithRandomFlatColorExcludingColorsInArray:(NSArray<UIColor *> * _Nonnull)colors;
		[Static]
		[Export ("colorWithRandomFlatColorExcludingColorsInArray:")]
		UIColor ColorWithRandomFlatColorExcludingColorsInArray (UIColor[] colors);

		// +(UIColor * _Nullable)colorWithRandomColorInArray:(NSArray<UIColor *> * _Nonnull)colors;
		[Static]
		[Export ("colorWithRandomColorInArray:")]
		[return: NullAllowed]
		UIColor ColorWithRandomColorInArray (UIColor[] colors);

		// +(UIColor * _Nonnull)colorWithRandomFlatColorOfShadeStyle:(UIShadeStyle)shadeStyle;
		[Static]
		[Export ("colorWithRandomFlatColorOfShadeStyle:")]
		UIColor ColorWithRandomFlatColorOfShadeStyle (UIShadeStyle shadeStyle);

		// +(UIColor * _Nonnull)colorWithRandomFlatColorOfShadeStyle:(UIShadeStyle)shadeStyle withAlpha:(CGFloat)alpha;
		[Static]
		[Export ("colorWithRandomFlatColorOfShadeStyle:withAlpha:")]
		UIColor ColorWithRandomFlatColorOfShadeStyle (UIShadeStyle shadeStyle, nfloat alpha);

		// +(UIColor * _Nonnull)colorWithAverageColorFromImage:(UIImage * _Nonnull)image;
		[Static]
		[Export ("colorWithAverageColorFromImage:")]
		UIColor ColorWithAverageColorFromImage (UIImage image);

		// +(UIColor * _Nonnull)colorWithAverageColorFromImage:(UIImage * _Nonnull)image withAlpha:(CGFloat)alpha;
		[Static]
		[Export ("colorWithAverageColorFromImage:withAlpha:")]
		UIColor ColorWithAverageColorFromImage (UIImage image, nfloat alpha);

		// +(UIColor * _Nonnull)colorWithComplementaryFlatColorOf:(UIColor * _Nonnull)color;
		[Static]
		[Export ("colorWithComplementaryFlatColorOf:")]
		UIColor ColorWithComplementaryFlatColorOf (UIColor color);

		// +(UIColor * _Nonnull)colorWithComplementaryFlatColorOf:(UIColor * _Nonnull)color withAlpha:(CGFloat)alpha;
		[Static]
		[Export ("colorWithComplementaryFlatColorOf:withAlpha:")]
		UIColor ColorWithComplementaryFlatColorOf (UIColor color, nfloat alpha);

		// +(UIColor * _Nonnull)colorWithContrastingBlackOrWhiteColorOn:(UIColor * _Nonnull)backgroundColor isFlat:(BOOL)flat;
		[Static]
		[Export ("colorWithContrastingBlackOrWhiteColorOn:isFlat:")]
		UIColor ColorWithContrastingBlackOrWhiteColorOn (UIColor backgroundColor, bool flat);

		// +(UIColor * _Nonnull)colorWithContrastingBlackOrWhiteColorOn:(UIColor * _Nonnull)backgroundColor isFlat:(BOOL)flat alpha:(CGFloat)alpha;
		[Static]
		[Export ("colorWithContrastingBlackOrWhiteColorOn:isFlat:alpha:")]
		UIColor ColorWithContrastingBlackOrWhiteColorOn (UIColor backgroundColor, bool flat, nfloat alpha);

		// +(UIColor * _Nonnull)colorWithGradientStyle:(UIGradientStyle)gradientStyle withFrame:(CGRect)frame andColors:(NSArray<UIColor *> * _Nonnull)colors;
		[Static]
		[Export ("colorWithGradientStyle:withFrame:andColors:")]
		UIColor ColorWithGradientStyle (UIGradientStyle gradientStyle, CGRect frame, UIColor[] colors);

		// +(UIColor * _Nullable)colorWithHexString:(NSString * _Nonnull)string;
		[Static]
		[Export ("colorWithHexString:")]
		[return: NullAllowed]
		UIColor ColorWithHexString (string @string);

		// +(UIColor * _Nullable)colorWithHexString:(NSString * _Nonnull)string withAlpha:(CGFloat)alpha;
		[Static]
		[Export ("colorWithHexString:withAlpha:")]
		[return: NullAllowed]
		UIColor ColorWithHexString (string @string, nfloat alpha);

		// -(UIColor * _Nonnull)flatten;
		[Export ("flatten")]
		[Verify (MethodToProperty)]
		UIColor Flatten { get; }

		// -(UIColor * _Nullable)darkenByPercentage:(CGFloat)percentage;
		[Export ("darkenByPercentage:")]
		[return: NullAllowed]
		UIColor DarkenByPercentage (nfloat percentage);

		// -(NSString * _Nonnull)hexValue;
		[Export ("hexValue")]
		[Verify (MethodToProperty)]
		string HexValue { get; }

		// -(UIColor * _Nullable)lightenByPercentage:(CGFloat)percentage;
		[Export ("lightenByPercentage:")]
		[return: NullAllowed]
		UIColor LightenByPercentage (nfloat percentage);

		// +(UIColor * _Nonnull)colorWithFlatVersionOf:(UIColor * _Nonnull)color __attribute__((deprecated(" Use -flatten: instead (First deprecated in Chameleon 2.0).")));
		[Static]
		[Export ("colorWithFlatVersionOf:")]
		UIColor ColorWithFlatVersionOf (UIColor color);
	}

	// @interface Chameleon (NSArray)
	[Category]
	[BaseType (typeof(NSArray))]
	interface NSArray_Chameleon
	{
		// +(NSArray *)arrayOfColorsWithColorScheme:(ColorScheme)colorScheme usingColor:(UIColor *)color withFlatScheme:(BOOL)isFlatScheme;
		[Static]
		[Export ("arrayOfColorsWithColorScheme:usingColor:withFlatScheme:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] ArrayOfColorsWithColorScheme (ColorScheme colorScheme, UIColor color, bool isFlatScheme);

		// +(NSArray *)arrayOfColorsFromImage:(UIImage *)image withFlatScheme:(BOOL)isFlatScheme;
		[Static]
		[Export ("arrayOfColorsFromImage:withFlatScheme:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] ArrayOfColorsFromImage (UIImage image, bool isFlatScheme);

		// +(NSArray *)arrayOfColorsWithColorScheme:(ColorScheme)colorScheme with:(UIColor *)color flatScheme:(BOOL)isFlatScheme __attribute__((deprecated(" Use -arrayOfColorsWithColorScheme:usingColor:withFlatScheme: instead (First deprecated in Chameleon 2.0).")));
		[Static]
		[Export ("arrayOfColorsWithColorScheme:with:flatScheme:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] ArrayOfColorsWithColorScheme (ColorScheme colorScheme, UIColor color, bool isFlatScheme);
	}

	// @interface Chameleon (UINavigationController)
	[Category]
	[BaseType (typeof(UINavigationController))]
	interface UINavigationController_Chameleon
	{
		// -(void)setStatusBarStyle:(UIStatusBarStyle)statusBarStyle;
		[Export ("setStatusBarStyle:")]
		void SetStatusBarStyle (UIStatusBarStyle statusBarStyle);

		// @property (assign, nonatomic) BOOL hidesNavigationBarHairline;
		[Export ("hidesNavigationBarHairline")]
		bool HidesNavigationBarHairline { get; set; }
	}

	// @interface Chameleon (UIViewController)
	[Category]
	[BaseType (typeof(UIViewController))]
	interface UIViewController_Chameleon
	{
		// -(void)setThemeUsingPrimaryColor:(UIColor *)primaryColor withContentStyle:(UIContentStyle)contentStyle;
		[Export ("setThemeUsingPrimaryColor:withContentStyle:")]
		void SetThemeUsingPrimaryColor (UIColor primaryColor, UIContentStyle contentStyle);

		// -(void)setThemeUsingPrimaryColor:(UIColor *)primaryColor withSecondaryColor:(UIColor *)secondaryColor andContentStyle:(UIContentStyle)contentStyle;
		[Export ("setThemeUsingPrimaryColor:withSecondaryColor:andContentStyle:")]
		void SetThemeUsingPrimaryColor (UIColor primaryColor, UIColor secondaryColor, UIContentStyle contentStyle);

		// -(void)setThemeUsingPrimaryColor:(UIColor *)primaryColor withSecondaryColor:(UIColor *)secondaryColor usingFontName:(NSString *)fontName andContentStyle:(UIContentStyle)contentStyle;
		[Export ("setThemeUsingPrimaryColor:withSecondaryColor:usingFontName:andContentStyle:")]
		void SetThemeUsingPrimaryColor (UIColor primaryColor, UIColor secondaryColor, string fontName, UIContentStyle contentStyle);

		// -(void)setStatusBarStyle:(UIStatusBarStyle)statusBarStyle;
		[Export ("setStatusBarStyle:")]
		void SetStatusBarStyle (UIStatusBarStyle statusBarStyle);
	}

	// @interface Chameleon : NSObject
	[BaseType (typeof(NSObject))]
	interface Chameleon
	{
		// +(void)setGlobalThemeUsingPrimaryColor:(UIColor *)primaryColor withContentStyle:(UIContentStyle)contentStyle;
		[Static]
		[Export ("setGlobalThemeUsingPrimaryColor:withContentStyle:")]
		void SetGlobalThemeUsingPrimaryColor (UIColor primaryColor, UIContentStyle contentStyle);

		// +(void)setGlobalThemeUsingPrimaryColor:(UIColor *)primaryColor withSecondaryColor:(UIColor *)secondaryColor andContentStyle:(UIContentStyle)contentStyle;
		[Static]
		[Export ("setGlobalThemeUsingPrimaryColor:withSecondaryColor:andContentStyle:")]
		void SetGlobalThemeUsingPrimaryColor (UIColor primaryColor, UIColor secondaryColor, UIContentStyle contentStyle);

		// +(void)setGlobalThemeUsingPrimaryColor:(UIColor *)primaryColor withSecondaryColor:(UIColor *)secondaryColor usingFontName:(NSString *)fontName andContentStyle:(UIContentStyle)contentStyle;
		[Static]
		[Export ("setGlobalThemeUsingPrimaryColor:withSecondaryColor:usingFontName:andContentStyle:")]
		void SetGlobalThemeUsingPrimaryColor (UIColor primaryColor, UIColor secondaryColor, string fontName, UIContentStyle contentStyle);
	}

	// @interface UIViewAppearance_Swift (UIView)
	[Category]
	[BaseType (typeof(UIView))]
	interface UIView_UIViewAppearance_Swift
	{
		// +(instancetype)appearanceWhenContainedWithin:(NSArray *)containers;
		[Static]
		[Export ("appearanceWhenContainedWithin:")]
		[Verify (StronglyTypedNSArray)]
		UIView AppearanceWhenContainedWithin (NSObject[] containers);
	}

	// @interface Chameleon (UIButton)
	[Category]
	[BaseType (typeof(UIButton))]
	interface UIButton_Chameleon
	{
		// -(void)setSubstituteFontName:(NSString *)name __attribute__((annotate("ui_appearance_selector")));
		[Export ("setSubstituteFontName:")]
		void SetSubstituteFontName (string name);
	}

	// @interface ChameleonPrivate (UIColor)
	[Category]
	[BaseType (typeof(UIColor))]
	interface UIColor_ChameleonPrivate
	{
		// @property (readwrite, nonatomic) NSUInteger count;
		[Export ("count")]
		nuint Count { get; set; }

		// +(UIColor *)colorFromImage:(UIImage *)image atPoint:(CGPoint)point;
		[Static]
		[Export ("colorFromImage:atPoint:")]
		UIColor ColorFromImage (UIImage image, CGPoint point);

		// -(UIColor *)colorWithMinimumSaturation:(CGFloat)saturation;
		[Export ("colorWithMinimumSaturation:")]
		UIColor ColorWithMinimumSaturation (nfloat saturation);

		// -(BOOL)isDistinct:(UIColor *)color;
		[Export ("isDistinct:")]
		bool IsDistinct (UIColor color);

		// -(BOOL)getValueForX:(CGFloat *)X valueForY:(CGFloat *)Y valueForZ:(CGFloat *)Z alpha:(CGFloat *)alpha;
		[Export ("getValueForX:valueForY:valueForZ:alpha:")]
		unsafe bool GetValueForX (nfloat* X, nfloat* Y, nfloat* Z, nfloat* alpha);

		// -(BOOL)getLightness:(CGFloat *)L valueForA:(CGFloat *)A valueForB:(CGFloat *)B alpha:(CGFloat *)alpha;
		[Export ("getLightness:valueForA:valueForB:alpha:")]
		unsafe bool GetLightness (nfloat* L, nfloat* A, nfloat* B, nfloat* alpha);
	}

	// @interface ChameleonPrivate (UIImage)
	[Category]
	[BaseType (typeof(UIImage))]
	interface UIImage_ChameleonPrivate
	{
		// +(UIImage *)imageWithImage:(UIImage *)image scaledToSize:(CGSize)newSize;
		[Static]
		[Export ("imageWithImage:scaledToSize:")]
		UIImage ImageWithImage (UIImage image, CGSize newSize);

		// -(UIImage *)imageScaledToSize:(CGSize)newSize;
		[Export ("imageScaledToSize:")]
		UIImage ImageScaledToSize (CGSize newSize);
	}

	// @interface Chameleon (UILabel)
	[Category]
	[BaseType (typeof(UILabel))]
	interface UILabel_Chameleon
	{
		// -(void)setSubstituteFontName:(NSString *)name __attribute__((annotate("ui_appearance_selector")));
		[Export ("setSubstituteFontName:")]
		void SetSubstituteFontName (string name);
	}

	// @interface ChameleonPrivate (UIView)
	[Category]
	[BaseType (typeof(UIView))]
	interface UIView_ChameleonPrivate
	{
		// -(BOOL)isTopViewInWindow;
		[Export ("isTopViewInWindow")]
		[Verify (MethodToProperty)]
		bool IsTopViewInWindow { get; }

		// -(UIView *)findTopMostViewForPoint:(CGPoint)point;
		[Export ("findTopMostViewForPoint:")]
		UIView FindTopMostViewForPoint (CGPoint point);
	}
}
