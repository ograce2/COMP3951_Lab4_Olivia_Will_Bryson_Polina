using CommunityToolkit.Mvvm.ComponentModel;

namespace SkeletoNoteLibrary.ViewModels;

public partial class EmbedPdfViewModel : ObservableObject
{
    [ObservableProperty]
    private string _pdf = "A whole entire pdf";
}
