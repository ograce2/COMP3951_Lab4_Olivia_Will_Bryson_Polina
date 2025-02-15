using CommunityToolkit.Mvvm.ComponentModel;

namespace BestSkeletoNote.ViewModels;

public partial class MarkdownRendererViewModel : ObservableObject
{
    [ObservableProperty]
    private string _renderedMarkdown = "### marky markdown";
}
