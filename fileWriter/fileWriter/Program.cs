using System;
using System.IO;

class WriteToFile
{
    public static void Main()
    {
        StreamWriter writer;
        // Creates file.txt on the desktop. @ symbol means don't interpret backslashes as control characters eg \n for newline
        writer = new StreamWriter(@"C:\Users\admin\Desktop\file.txt");
        // Writes "hello world" to the text file
        writer.WriteLine("hello world\nline 2");
        // Closes the stream
        writer.Close();

        // Open the file for reading as a stream
        StreamReader reader = new StreamReader("file.txt");
        // While the stream hasn't reached its end (signaled by an empty string being returned)
        while (reader.EndOfStream == false)
        {
            // Read the file contents and store it as a variable
            string line = reader.ReadLine();
            // Output the contents of the file to the console window
            Console.WriteLine(line);
        }
        // Close the read stream
        reader.Close();
        // Wait for interaction from the user so we can actually see the terminal output
        Console.ReadKey();
    }
}