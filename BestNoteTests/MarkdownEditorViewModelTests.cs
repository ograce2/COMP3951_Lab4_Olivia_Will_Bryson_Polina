using SkeletoNoteLibrary.ViewModels;

namespace BestNoteTests
{
    public class MarkdownEditorViewModelTests
    {
        [Fact]
        public void TestEditorText_Success()
        {
            var editorVM = new MarkdownEditorViewModel();
            var testText = "Marky Markdown";

            editorVM.Text = "Marky Markdown";

            Assert.Equal(testText, editorVM.Text);
        }

        [Fact]
        public void TestPlaceholderText_NotNull()
        {
            var editorVM = new MarkdownEditorViewModel();

            Assert.NotNull(editorVM.Text);
        }
    }
}
