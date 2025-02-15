namespace BestNoteSkeleton.Views;

public class EmbedPdfView : ContentView
{
	public EmbedPdfView()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}