using CommunityToolkit.Mvvm.ComponentModel;

namespace BestNoteSkeleton.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public FileStructureViewModel FileExplorer { get; } = new();
        public MarkdownEditorViewModel Editor { get; } = new();

    }
}
