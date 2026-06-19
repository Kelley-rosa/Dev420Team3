using System;
using Microsoft.Owin.Hosting;

namespace HospitalSignalRServer
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:8080";

            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine("SignalR server running on " + url);
                Console.WriteLine("Press any key to stop the server...");
                Console.ReadKey();
            }
        }
    }
}
