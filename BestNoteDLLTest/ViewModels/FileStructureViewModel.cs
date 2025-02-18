using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

/// <summary>
/// Lab 4: BestNote Unit Testing
/// Authors: Olivia Grace, Bryson Lindy, Polina Omelyantseva, Will Otterbein
/// Revised: February 17, 2025
/// </summary>
namespace SkeletoNoteLibrary.ViewModels;

public partial class FileStructureViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<string> _files = new()
    {
        "some_sick-ass_notes.md",
    };
}
