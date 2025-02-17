using SkeletoNoteLibrary.ViewModels;

namespace BestNoteTests
{
    public class FileStructureViewModelTests
    {
        /*
         * Add and remove are just Collection methods but we don't really have anything else to test here righ tnow
         */
        [Fact]
        public void TestAddFile_Success()
        {
            var filesVM = new FileStructureViewModel();

            filesVM.Files.Add("some_notes.md");

            Assert.Equal(2, filesVM.Files.Count); // 2 because of the placeholder file
            Assert.Contains("some_notes.md", filesVM.Files);
        }

        [Fact]
        public void TestRemoveFile_Success()
        {
            var filesVM = new FileStructureViewModel();

            filesVM.Files.Remove("some_sick-ass_notes.md");

            Assert.Empty(filesVM.Files);
        }
    }
}