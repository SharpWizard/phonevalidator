using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace phonevalidator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Replace 'xxxxxxxxxx' with the actual phone number and 'xxx@x.com' with the actual email address
            string phoneNumber = "xxxxxxxxxx";
            string emailAddress = "xxx@mail.com";

            // Construct the API endpoint URL with the provided phone number and email
            string apiUrl = $"https://phonevalidator.xyz/api/validator.aspx/validate?phone={phoneNumber}&email={emailAddress}";

            // Create a new WebClient instance
            WebClient client = new WebClient();

            try
            {
                // Make the HTTP GET request to the API
                string response = client.DownloadString(apiUrl);

                // Process the API response as needed
                Console.WriteLine(response);
            }
            catch (WebException ex)
            {
                // An error occurred while making the request
                Console.WriteLine("Error occurred: " + ex.Message);
            }

            Console.ReadKey();

        }
    }
}
