using CommunityToolkit.Mvvm.ComponentModel;

namespace BestSkeletoNote.ViewModels;

public partial class MarkdownEditorViewModel : ObservableObject
{
    [ObservableProperty]
    private string _text = "Now we typin...";
}



