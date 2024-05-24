using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Opening applications...");

        // Opens Edge and navigates to Gmail
        OpenUrlInEdge("https://mail.google.com");

        // Opens Edge and navigates to Outlook
        OpenUrlInEdge("https://outlook.office.com/mail/");

        // Opens Visual Studio
        OpenApplication(@"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe");

        // Opens Obsidian
        OpenApplication(@"C:\Users\ryant\AppData\Local\Programs\obsidian\Obsidian.exe");

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

    // Generalized method to open any application given its path.
    static void OpenApplication(string applicationPath)
    {
        try
        {
            Process.Start(applicationPath);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Could not open application at {applicationPath}: {ex.Message}");
        }
    }
}
