using System;
using System.IO;
using RestSharp;

namespace TestProject.Connect
{
    public class SrvConnection
    {
        public void Upload(string filePath, string targetURL)
        {
            try
            {
                RestClient client = new RestClient(targetURL);
                RestRequest request = new RestRequest(Method.Post.ToString());
                request.AddHeader("Content-Type", "text/plain");
                var fileBytes = File.ReadAllBytes(filePath);
                request.AddFile("file", fileBytes, Path.GetFileName(filePath));
                var response = client.Execute(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Console.WriteLine("File uploaded succesfully");
                }
                else
                {
                    Console.WriteLine($"File uploaded error. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occur: {ex.Message}");
            }
        }
    }
}