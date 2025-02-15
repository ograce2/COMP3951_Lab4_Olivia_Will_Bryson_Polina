using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace BestSkeletoNote.ViewModels;

public partial class FileStructureViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<string> _files = new()
    {
        "some_sick-ass_notes.md",
    };
}
