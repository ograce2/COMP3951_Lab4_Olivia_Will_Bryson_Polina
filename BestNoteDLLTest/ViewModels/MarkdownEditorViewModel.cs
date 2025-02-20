using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;

/// <summary>
/// Lab 4: BestNote Unit Testing
/// Authors: Olivia Grace, Bryson Lindy, Polina Omelyantseva, Will Otterbein
/// Revised: February 17, 2025
/// </summary>
namespace SkeletoNoteLibrary.ViewModels;

/// <summary>
/// The BufferWriteException class is an exception which is thrown when the buffer is full.
/// </summary>
public class BufferWriteException : Exception
{
    public EmployeeListNotFoundException(string message)
        : base(message)
    {
    }
}

/// <summary>
/// The BufferWriteException class is an exception which is thrown when the buffer is full.
/// </summary>
public class BufferNotEmptyException : Exception
{
    public EmployeeListNotFoundException(string message)
        : base(message)
    {
    }
}

/// <summary>
/// The MarkdownEditorViewModel class contains data displayed in MarkdownEditorView.xaml.
/// </summary>
public partial class MarkdownEditorViewModel : ObservableObject
{
    /// <summary>
    /// The current text in the Markdown editor.
    /// </summary>
    [ObservableProperty]
    private string _text = "Now we typin...";
    private int lastByte = 0;

    public byte[] Buffer { get; set; } = new byte[1024];

    /// <summary>
    /// Writing bytes to the buffer (everytime the user is typing into the editor box).
    /// </summary>
    private bool FlushBuffer()
    {
        // Raise an exception that the buffer is full
        // Logic elsewhere for writing the bytes in the file class
        throw new BufferWriteException();
    }

    /// <summary>
    /// Writing bytes to the buffer (everytime the user is typing into the editor box).
    /// </summary>
    public void WriteBytesToBuffer(byte[] nbytes)
    {
        for (int i = 0; i < nbytes.Length; i++)
        {
            // Writing bytes to a buffer
            Buffer[lastByte++] = nbytes[i];
            if (lastByte == Buffer.Length - 1)
                FlushBuffer();
        }
    }

    /// <summary>
    /// Writing bytes to the buffer (everytime the user is typing into the editor box).
    /// </summary>
    public void ResetBuffer()
    {
        // Last byte not being the end means it is not empty
        // Buffer needs to be flushed before it can be reset
        if (lastByte <= Buffer.Length - 1)
            throw new BufferNotEmptyException();

        lastByte = 0;
        Buffer = new byte[1024];
    }
}
