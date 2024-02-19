using NUnit.Framework;
using System.IO;

[TestFixture]
public class FileReverserTests
{

    [Test]
    public void ReverseFile_InputFileExists_OutputFileCreatedWithReversedContents()
    {
        // Arrange
        string inputFilePath = "input.txt";
        string outputFilePath = "output.txt";
        File.WriteAllText(inputFilePath, "Line 1\nLine 2\nLine 3");

        // Act
        var fileReverser = new FileUtility();
        fileReverser.ReverseFile(inputFilePath, outputFilePath);

        // Assert
        Assert.IsTrue(File.Exists(outputFilePath));
        string[] reversedLines = File.ReadAllLines(outputFilePath);
        Assert.AreEqual("3 eniL", reversedLines[0]);
        Assert.AreEqual("2 eniL", reversedLines[1]);
        Assert.AreEqual("1 eniL", reversedLines[2]);

        // Cleanup
        File.Delete(inputFilePath);
        File.Delete(outputFilePath);
    }

}
