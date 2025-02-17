using SkeletoNoteLibrary.ViewModels;

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
    }
}
