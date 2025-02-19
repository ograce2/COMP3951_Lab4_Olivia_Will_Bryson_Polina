using CommunityToolkit.Mvvm.ComponentModel;

/// <summary>
/// Lab 4: BestNote Unit Testing
/// Authors: Olivia Grace, Bryson Lindy, Polina Omelyantseva, Will Otterbein
/// Revised: February 17, 2025
/// </summary>
namespace SkeletoNoteLibrary.ViewModels;

/// <summary>
/// The MarkdownEditorViewModel class contains data displayed in MarkdownEditorView.xaml.
/// </summary>
public partial class MarkdownEditorViewModel : ObservableObject
{
    /// <summary>
    /// The current text in the Markdown editor.
    /// </summary>
    [ObservableProperty]
    private string _text = "Now we typin...";
}



