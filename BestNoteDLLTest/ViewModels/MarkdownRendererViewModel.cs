using CommunityToolkit.Mvvm.ComponentModel;

namespace SkeletoNoteLibrary.ViewModels;

public partial class MarkdownRendererViewModel : ObservableObject
{
    [ObservableProperty]
    private string _renderedMarkdown = "### marky markdown";
}
