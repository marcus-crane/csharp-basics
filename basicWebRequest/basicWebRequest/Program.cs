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

            string serverResponse;
            // You can stack usings on top of each other!
            using(Stream newsStream = response.GetResponseStream())
            using(StreamReader reader = new StreamReader(newsStream))
            {
                // Read the actual content
                serverResponse = reader.ReadToEnd();
            }
            // No need to close/dispose of the readers, as this will be done
            // for us! It's a bit of a preference whether you call .Close()
            // and some Close() even call Dispose() for you, but for readability
            // and to make things clear, I prefer just the using statement.

            // Output the response to the terminal
            Console.WriteLine(serverResponse);
        }
    }
}
