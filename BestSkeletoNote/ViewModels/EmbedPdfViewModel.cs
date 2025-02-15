using CommunityToolkit.Mvvm.ComponentModel;

namespace BestSkeletoNote.ViewModels;

public partial class EmbedPdfViewModel : ObservableObject
{
    [ObservableProperty]
    private string _pdf = "A whole entire pdf";
}
