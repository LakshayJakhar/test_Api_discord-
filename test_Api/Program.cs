using System;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

class Program
{
    //static async Task Main()
    //{
    //    string url = "https://www.reddit.com/r/dogs/.json";

    //    using (HttpClient client = new HttpClient())
    //    {
    //        // Add headers to the request
    //        client.DefaultRequestHeaders.Add("User-Agent", "myApp/1.0 (http://mywebsite.com)");

    //        // Send the GET request and get the response
    //        HttpResponseMessage response = await client.GetAsync(url);

    //        // Read the response content as a string
    //        string responseData = await response.Content.ReadAsStringAsync();

    //        // Parse the JSON response
    //        JObject jsonResponse = JObject.Parse(responseData);



    //         // Navigate to the 'children' array and print the 'title' of each post
    //        foreach (var yugi in jsonResponse["data"]["children"])
    //        {
    //            string title = yugi["data"]["name"].ToString();

    //            Console.WriteLine( title);
    //        }

    //    }
    //}

    static async Task Main()
    {
        // Discord webhook URL
        string url = "https://discord.com/api/webhooks/1308018099118669886/SZy_xRpZ2bVrAqOYjwVnqjDRQf-t1HWwc0rZcuZn9wJvJMvKGRN0jX2cbatGr9pJroUa";

        // Path to your image file
        string imagePath = "C:\\Users\\laksh\\Desktop\\Case Study\\test_Api\\test_Api\\download.jfif";

        using (HttpClient client = new HttpClient())
        {
            // Prepare the form data
            var formData = new MultipartFormDataContent();

            // Add the message to the form data (Discord will show this message alongside the image)
            var jsonContent = new StringContent("{\"content\": \"Fuck you all\"}", Encoding.UTF8, "application/json");
            formData.Add(jsonContent, "payload_json");

            // Read the image file
            var imageBytes = File.ReadAllBytes(imagePath);
            var imageContent = new ByteArrayContent(imageBytes);
            formData.Add(imageContent, "file", Path.GetFileName(imagePath));  // "file" is the form field for the image

            // Send the POST request with the form data (message + image)
            HttpResponseMessage response = await client.PostAsync(url, formData);

            // Check the response status
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Message and image sent successfully!");
            }
            else
            {
                Console.WriteLine($"Failed to send message. Status Code: {response.StatusCode}");
            }
        }
    }
}
