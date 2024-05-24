using System;
using System.Diagnostics;

namespace OpenApplications
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opening applications...");

            // Opens Edge and navigates to Gmail
            OpenUrlInEdge("https://mail.google.com");

            // Opens Edge and navigates to Outlook
            OpenUrlInEdge("https://outlook.office.com/mail/");

            //// Opens Visual Studio
            //OpenVisualStudio();

            Console.WriteLine("Applications should now be open.");
            Console.ReadLine(); // Keep the console window open
        }

        static void OpenUrlInEdge(string url)
        {
            try
            {
                Process.Start("cmd.exe", $"/c start msedge {url}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not open URL in Edge: " + ex.Message);
            }
        }

    }
}
