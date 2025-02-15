using BestSkeletoNote.ViewModels;

namespace BestSkeletoNote.Views;

public partial class EmbedPdfView : ContentView
{
	public EmbedPdfView()
	{
		InitializeComponent();
		BindingContext = new EmbedPdfViewModel();
	}
}