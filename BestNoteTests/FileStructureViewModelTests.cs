using SkeletoNoteLibrary.ViewModels;

/// <summary>
/// Lab 4: BestNote Unit Testing
/// Authors: Olivia Grace, Bryson Lindy, Polina Omelyantseva, Will Otterbein
/// Revised: February 17, 2025
/// </summary>
namespace BestNoteTests
{
    /// <summary>
    /// Unit tests for the FileStructureViewModel class.
    /// </summary>
    public class FileStructureViewModelTests
    {
 
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

            filesVM.Files.Remove("some_cool_notes.md");

            Assert.Empty(filesVM.Files);
        }
    }
}