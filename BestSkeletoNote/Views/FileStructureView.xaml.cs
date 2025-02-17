using SkeletoNoteLibrary.ViewModels;

namespace BestSkeletoNote.Views;

public partial class FileStructureView : ContentView
{
	public FileStructureView()
	{
		InitializeComponent();
		BindingContext = new FileStructureViewModel();
	}
}