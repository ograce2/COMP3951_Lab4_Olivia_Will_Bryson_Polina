using System.Reflection;
using CommunityToolkit.Mvvm.ComponentModel;

/// <summary>
/// Lab 4: BestNote Unit Testing
/// Authors: Olivia Grace, Bryson Lindy, Polina Omelyantseva, Will Otterbein
/// Revised: February 17, 2025
/// </summary>
namespace SkeletoNoteLibrary.ViewModels;


/// <summary>
///  Main view model. This is where we manage the logic for the views.
///  Anything that get changes in the view models that this calls bubbles up
///  to the MainPage. 
/// </summary>
public partial class MainViewModel : ObservableObject
{

    /// <summary>
    /// The file structure.
    /// </summary>
    public FileStructureViewModel Files { get; } = new();

    /// <summary>
    /// The Markdown editor.
    /// </summary>
    public MarkdownEditorViewModel Editor { get; } = new();

    /// <summary>
    /// The Markdown renderer.
    /// </summary>
    public MarkdownRendererViewModel Renderer { get; } = new();

    /// <summary>
    /// The PDF resource viewer.
    /// </summary>
    public EmbedPdfViewModel Pdf { get; } = new();
}
