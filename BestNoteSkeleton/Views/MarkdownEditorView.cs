namespace BestNoteSkeleton.Views;

public class MarkdownEditorView : ContentView
{
	public MarkdownEditorView()
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