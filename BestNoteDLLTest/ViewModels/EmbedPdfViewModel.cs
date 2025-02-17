using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;

namespace SkeletoNoteLibrary.ViewModels;

public partial class EmbedPdfViewModel : ObservableObject
{
    [ObservableProperty]
    private string _pdf = "A whole entire pdf";

    /// <summary>
    /// Loads the PDF file stored in the Pdf observable property. If the file is not found, the function throws a FileNotFound exception.
    /// </summary>
    public void LoadPDF()
    {
        using (FileStream fileStream = File.Open(Pdf, FileMode.Open, FileAccess.Read, FileShare.None))
        {
           

        }
    }
}
