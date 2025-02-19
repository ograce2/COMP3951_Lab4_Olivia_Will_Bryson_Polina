using SkeletoNoteLibrary.ViewModels;

/// <summary>
/// Lab 4: BestNote Unit Testing
/// Authors: Olivia Grace, Bryson Lindy, Polina Omelyantseva, Will Otterbein
/// Revised: February 17, 2025
/// </summary>
namespace BestNoteTests
{

    /// <summary>
    /// Unit tests for the MarkdownEditorViewModel class.
    /// </summary>
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
