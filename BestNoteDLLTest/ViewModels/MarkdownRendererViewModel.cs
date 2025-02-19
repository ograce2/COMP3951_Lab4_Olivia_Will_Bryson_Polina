using CommunityToolkit.Mvvm.ComponentModel;

/// <summary>
/// Lab 4: BestNote Unit Testing
/// Authors: Olivia Grace, Bryson Lindy, Polina Omelyantseva, Will Otterbein
/// Revised: February 17, 2025
/// </summary>
namespace SkeletoNoteLibrary.ViewModels;

/// <summary>
/// The MarkdownRendererViewModel class contains data displayed in MarkdownRendererView.xaml.
/// </summary>
public partial class MarkdownRendererViewModel : ObservableObject
{
    /// <summary>
    /// The rendered Markdown to display.
    /// </summary>
    [ObservableProperty]
    private string _renderedMarkdown = "### marky markdown";
}
