using SkeletoNoteLibrary.ViewModels;

namespace BestNoteTests
{
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
