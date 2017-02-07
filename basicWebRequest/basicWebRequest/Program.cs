using System;
using System.IO;
using System.Net;

namespace basicWebRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a request to fetch data from my own site (which is small and is easily readable as HTML)
            WebRequest request = WebRequest.Create("http://thingsima.de");
            // Get the response in regards to the request
            WebResponse response = request.GetResponse();
            // Output the status (OK / 200) to the terminal
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the actual content from the stream returned by the server
            Stream newsStream = response.GetResponseStream();
            // Create an instance of the StreamReader class and pass it the content stream
            StreamReader reader = new StreamReader(newsStream);
            // Read the actual content
            string serverResponse = reader.ReadToEnd();
            // Output the response to the terminal
            Console.WriteLine(serverResponse);
            // Close the reader stream and response stream
            reader.Close();
            response.Close();
        }
    }
}
