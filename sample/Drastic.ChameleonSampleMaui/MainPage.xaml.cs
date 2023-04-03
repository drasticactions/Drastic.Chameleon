using UIKit;
using ChameleonFramework;

namespace Drastic.ChameleonSampleMaui;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);

		var testing = (UIImageView)this.DotNetBot.Handler.PlatformView;
		var fart = ChameleonColor.GetImageAverageColor(null, testing.Image);
		fart.GetRGBA(out var r, out var g, out var b, out var a);
		this.BackgroundColor = Color.FromRgba(r, g, b, a);
    }
}

