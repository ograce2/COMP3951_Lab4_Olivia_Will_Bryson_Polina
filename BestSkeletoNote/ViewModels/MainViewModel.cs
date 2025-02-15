using CommunityToolkit.Mvvm.ComponentModel;

namespace BestSkeletoNote.ViewModels;

/*
 * main view model. this is where we manage the logic for the views.
 * anything that get changes in the view models that this calls bubbles up
 * to the MainPage. 
 */
public partial class MainViewModel : ObservableObject
{
    public FileStructureViewModel Files { get; } = new();
    public MarkdownEditorViewModel Editor { get; } = new();
    public MarkdownRendererViewModel Renderer { get; } = new();
    public EmbedPdfViewModel Pdf { get; } = new();
}
