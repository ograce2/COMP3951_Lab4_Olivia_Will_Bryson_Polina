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

        /// <summary>
        /// Testing method writes bytes to a buffer and succeeds.
        /// </summary>
        [Fact]
        public void TestWriteToBuffer()
        {
            var mem = new MarkdownEditorViewModel();
            mem.WriteBytesToBuffer(new byte[500]);
            Assert.True(true);
        }

        /// <summary>
        /// Testing method writes bytes to a buffer and fills the buffer.
        /// </summary>
        [Fact]
        public void TestWriteToBuffer_BufferFills()
        {
            var mem = new MarkdownEditorViewModel();
            Assert.Throws<BufferWriteException>(() => mem.WriteBytesToBuffer(new byte[1025]));
        }

        /// <summary>
        /// Testing method resets the buffer after filling it.
        /// </summary>
        [Fact]
        public void TestResetBuffer()
        {
            var mem = new MarkdownEditorViewModel();
            // Fill the buffer
            mem.WriteBytesToBuffer(new byte[1024]);
            // Should not throw exception and pass
            mem.ResetBuffer();
            Assert.True(true);
        }

        /// <summary>
        /// Testing method resets the buffer but it is not full.
        /// </summary>
        [Fact]
        public void TestResetBuffer_BufferNotFull()
        {
            var mem = new MarkdownEditorViewModel();
            Assert.Throws<BufferNotEmptyException>(() => mem.ResetBuffer());
        }
    }
}
