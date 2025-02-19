using SkeletoNoteLibrary.ViewModels;

/// <summary>
/// Lab 4: BestNote Unit Testing
/// Authors: Olivia Grace, Bryson Lindy, Polina Omelyantseva, Will Otterbein
/// Revised: February 17, 2025
/// </summary>
namespace BestNoteTests
{

    /// <summary>
    /// Unit tests for the MarkdownRendererViewModel class.
    /// </summary>
    public class MarkdownRendererViewModelTests
    {
        [Fact]
        public void TestDefaultValue_Exists()
        {
            var renderVM = new MarkdownRendererViewModel();

            Assert.Equal("### marky markdown", renderVM.RenderedMarkdown);
        }

        [Fact]
        public void TestValueUpdates_Success()
        {
            var renderVM = new MarkdownRendererViewModel();
            var value = "## heady heading";

            renderVM.RenderedMarkdown = "## heady heading";

            Assert.Equal(value, renderVM.RenderedMarkdown);
        }
    }
}
