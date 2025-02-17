using SkeletoNoteLibrary.ViewModels;

namespace BestSkeletoNote.Views;

public partial class MarkdownRendererView : ContentView
{
	public MarkdownRendererView()
	{
		InitializeComponent();
		BindingContext = new MarkdownRendererViewModel();
	}
}