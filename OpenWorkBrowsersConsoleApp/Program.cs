using System;
using System.Diagnostics;

// This console application is designed to automate the opening of various web browsers and applications
// at the start of a workday or when needed. It allows users to quickly launch frequently used websites
// in different browsers such as Microsoft Edge, Google Chrome, Mozilla Firefox, and Brave. Additionally,
// it provides a method to open any application by specifying its file path, facilitating quick access
// to essential tools like Visual Studio or custom applications. 
// Initially, this application will open gmail, outlook, and github in Microsoft Edge. Modify it to suit your needs.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Opening applications...");

        // Opens Edge and navigates to Gmail
        OpenUrlInEdge("https://mail.google.com");

        // Opens Edge and navigates to Outlook
        OpenUrlInEdge("https://outlook.office.com/mail/");

        // Opens Github in Edge and navigates to Github
        OpenUrlInEdge("https://github.com");

        //// Opens Github in Chrome
        //OpenUrlInChrome("https://github.com");

        //// Opens example.com in Firefox
        //OpenUrlInFirefox("https://www.example.com");

        //// Opens a specific URL in Brave
        //OpenUrlInBrave("https://news.ycombinator.com");

        //Manually enter filepaths for custom applications
        //OpenApplication("C:\\Program Files\\Microsoft Office\\root\\Office16\\OUTLOOK.EXE");

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

    static void OpenUrlInChrome(string url)
    {
        try
        {
            Process.Start("cmd.exe", $"/c start chrome {url}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Could not open URL in Chrome: " + ex.Message);
        }
    }

    static void OpenUrlInFirefox(string url)
    {
        try
        {
            Process.Start("cmd.exe", $"/c start firefox {url}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Could not open URL in Firefox: " + ex.Message);
        }
    }

    static void OpenUrlInBrave(string url)
    {
        try
        {
            Process.Start("cmd.exe", $"/c start brave {url}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Could not open URL in Brave: " + ex.Message);
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
