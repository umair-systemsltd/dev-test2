using System.IO;

public class FileUtility
{
    public void ReverseFile(string inputFilePath, string outputFilePath)
    {
        try
        {
            // Read the input file
            string[] lines = File.ReadAllLines(inputFilePath);

            // Reverse the contents
            Array.Reverse(lines);

           
            for (int i = 0; i < lines.Length; i++)
            {
                char[] charArray = lines[i].ToCharArray();
                Array.Reverse(charArray);
                lines[i] = new string(charArray);
            }

            // Write the reversed contents to the output file
            File.WriteAllLines(outputFilePath, lines);
        }catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
