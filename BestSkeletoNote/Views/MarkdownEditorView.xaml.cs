using BestSkeletoNote.ViewModels;

namespace BestSkeletoNote.Views;

public partial class MarkdownEditorView : ContentView
{
	public MarkdownEditorView()
	{
		InitializeComponent();
		BindingContext = new MarkdownEditorViewModel();
	}
}