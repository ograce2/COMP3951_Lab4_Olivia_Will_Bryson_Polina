using SkeletoNoteLibrary.ViewModels;

/// <summary>
/// Lab 4: BestNote Unit Testing
/// Authors: Olivia Grace, Bryson Lindy, Polina Omelyantseva, Will Otterbein
/// Revised: February 17, 2025
/// </summary>
namespace BestNoteTests
{
    public class EmbedPdfViewModelTests
    {
        [Fact]
        public void TestDefaultPdf_Exists()
        {
            var pdfVM = new EmbedPdfViewModel();

            Assert.Equal("A whole entire pdf", pdfVM.Pdf);
        }

        [Fact]
        public void TestValueUpdates_Success()
        {
            var pdfVM = new EmbedPdfViewModel();
            var value = "textbook.pdf";

            pdfVM.Pdf = value;

            Assert.Equal(value, pdfVM.Pdf);
        }

        [Fact]
        public void TestLoadPDF_FileNotFoundException()
        {
            var pdfVM = new EmbedPdfViewModel();
            var value = "invalid.pdf";

            pdfVM.Pdf = value;
            Assert.Throws<FileNotFoundException>(() => pdfVM.LoadPDF());
        }


        [Fact]
        public void TestValidatePDF_True()
        {
            var pdfVM = new EmbedPdfViewModel();
            var value = "textbook.pdf";
            pdfVM.Pdf = value;
            Assert.True(pdfVM.ValidateFileType());
        }

        [Fact]
        public void TestValidatePDF_False()
        {
            var pdfVM = new EmbedPdfViewModel();
            var value = "textbook.txt";
            pdfVM.Pdf = value;
            Assert.False(pdfVM.ValidateFileType());
        }
    }
}
