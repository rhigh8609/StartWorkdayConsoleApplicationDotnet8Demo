# StartWorkday Application

## Overview
The StartWorkday application is a .NET 8 console application designed to automate the opening of various applications and websites that you may use at the beginning of your workday. This includes launching web browsers with specific URLs such as Gmail and Outlook, as well as opening applications like Visual Studio and Obsidian. The application also supports multiple browsers, allowing users to open websites in Microsoft Edge, Google Chrome, Mozilla Firefox, and Brave. It's particularly useful for users who want to streamline the startup process of their workday with a single command.

## Features
- **Open Web Pages in Browser**: Automatically opens URLs in different browsers:
  - Microsoft Edge for Gmail and Outlook.
  - Google Chrome for GitHub.
  - Mozilla Firefox and Brave for custom URLs.
- **Launch Applications**: Opens key applications like Visual Studio and Obsidian, setting up your development and note-taking environments without manual effort.
- **Extendability**: Easily configurable to add more websites or applications as per individual needs. Supports multiple web browsers to fit user preferences.

## Usage
To run the StartWorkday application:
1. Ensure that .NET 8 is installed on your system.
2. Navigate to the directory containing the StartWorkday executable.
3. Run the executable via the command line or by double-clicking the application icon.

## Requirements
- Windows Operating System
- .NET 8
- Applications and web pages mentioned must be installed or accessible on the default paths, or paths must be updated in the source code.

## Example of Good Practices
This application serves as a good example of several software development best practices:
- **Simplicity**: The application does not over-complicate the tasks it is designed to perform. It focuses on a simple, clear purpose—opening necessary applications and websites automatically.
- **Modularity**: Functionality is broken down into distinct methods (e.g., `OpenUrlInEdge`, `OpenUrlInChrome`, `OpenUrlInFirefox`, `OpenUrlInBrave`, and `OpenApplication`), demonstrating modularity. This makes the code easier to manage, test, and reuse.
- **DRY Principle**: Through the use of a generic method for opening applications (`OpenApplication`), the application adheres to the "Don't Repeat Yourself" principle, reducing the need for redundant code.
- **Error Handling**: Implements basic error handling to manage and report issues that may occur during the execution of external processes, ensuring that the user is informed of failures without crashing the application.

## Configuration
To customize which applications or websites are opened:
1. Edit the `Main` method to include or exclude calls to `OpenUrlInEdge`, `OpenUrlInChrome`, `OpenUrlInFirefox`, `OpenUrlInBrave`, or `OpenApplication` as desired.
2. Modify the paths in the calls to `OpenApplication` if your applications are located in different directories.

## License
This project is released under the MIT License. Feel free to use, modify, and distribute as you see fit.
