using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;

/// <summary>
/// Lab 4: BestNote Unit Testing
/// Authors: Olivia Grace, Bryson Lindy, Polina Omelyantseva, Will Otterbein
/// Revised: February 17, 2025
/// </summary>
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

    /// <summary>
    /// Validates that the string in the Pdf property is a path to .pdf file.
    /// </summary>
    /// <returns>true if the path ends in ".pdf", false otherwise</returns>
    public Boolean ValidateFileType()
    {
        Boolean validFile = false;
        if (Pdf.Length > 0 && Pdf.Substring(Pdf.Length - 4).ToUpper() == ".PDF") {
            validFile = true;
        }

        return validFile;
    }
}
