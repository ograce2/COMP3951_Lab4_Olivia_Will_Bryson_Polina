using CommunityToolkit.Mvvm.ComponentModel;

/// <summary>
/// Lab 4: BestNote Unit Testing
/// Authors: Olivia Grace, Bryson Lindy, Polina Omelyantseva, Will Otterbein
/// Revised: February 17, 2025
/// </summary>
namespace SkeletoNoteLibrary.ViewModels;

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
