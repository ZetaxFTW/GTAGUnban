// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.IO.Compression;
using System.Net;
using Microsoft.Win32;

Console.ForegroundColor = ConsoleColor.Blue;
DateTime dt = DateTime.Now;
Console.WriteLine(DateTime.Now);
Console.WriteLine();
Console.WriteLine("░██████╗░████████╗░█████╗░░██████╗░   ██╗░░░██╗███╗░░██╗██████╗░░█████╗░███╗░░██╗");
Console.WriteLine("██╔════╝░╚══██╔══╝██╔══██╗██╔════╝░   ██║░░░██║████╗░██║██╔══██╗██╔══██╗████╗░██║");
Console.WriteLine("██║░░██╗░░░░██║░░░███████║██║░░██╗░   ██║░░░██║██╔██╗██║██║████║██║░░██║██╔██╗██║");
Console.WriteLine("██║░░╚██╗░░░██║░░░██╔══██║██║░░╚██╗░  ██║░░░██║██║╚████║██║░░██║██║████║██║╚████║");
Console.WriteLine("╚██████╔╝░░░██║░░░██║░░██║╚██████╔╝░  ╚██████╔╝██║░╚███║╚█████╔╝██║░░██║██║░╚███║");
Console.WriteLine("░╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚═════╝░░  ░╚═════╝░╚═╝░░╚══╝░╚════╝░╚═╝░░╚═╝╚═╝░░╚══╝");
Console.WriteLine();
//ask for input
Console.WriteLine("Do you wish to proceed? (y/n)");
string input = Console.ReadLine();
if (input == "y")
{
    Console.WriteLine("Proceeding...");
    Console.WriteLine("Done!");
    Console.WriteLine("Registry edited...");
    Console.WriteLine();
    System.Threading.Thread.Sleep(2000);
    Main();
}
else if (input == "n")
{
    Console.WriteLine();
    Console.WriteLine("Thank you for using the program!");
    Console.WriteLine();
    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
    Environment.Exit(0);
}

void Main()
{
    //If directory exists, delete it
    if (Directory.Exists(@"C:\Users\Public\LocalLow\Another Axiom\Gorilla Tag"))
    {
        Directory.Delete(@"C:\Users\Public\LocalLow\Another Axiom\Gorilla Tag", true);
        Console.WriteLine("Deleted traces from GTAG");
    }
    else
    {
        Console.WriteLine("No traces from GTAG found");
    }
    WebClient client = new WebClient();
    string user = Environment.UserName;
    //if file exists, delete it
    if (File.Exists(@"C:\Users\" + user + @"\LocalLow\Another Axiom\Gorilla Tag\0.0.1.zip"))
    {
        File.Delete(@"C:\Users\" + user + @"\LocalLow\Another Axiom\Gorilla Tag\0.0.1.zip");
        Directory.Delete(@"C:\Users\" + user + @"\LocalLow\Another Axiom\Gorilla Tag\0.0.1", true);
        Console.WriteLine("Deleted Spoofer");
    }
    else
    {
        Console.WriteLine("Spoofer not found. Downloading now...");
        client.DownloadFile("https://github.com/sr2echa/Monotone-HWID-Spoofer/archive/refs/tags/0.0.1.zip", "0.0.1.zip");
        //extract file to local directory
        //if directory exists, delete it
        if (Directory.Exists("/Monotone-HWID-Spoofer-0.0.1"))
        {
            Directory.Delete("/Monotone-HWID-Spoofer-0.0.1", true);
            Console.WriteLine("Deleted old directory");
        }
        ZipFile.ExtractToDirectory("0.0.1.zip", "/");
        
    }
    //extract to user name home directory
    Console.WriteLine("Downloaded and extracted Monotone-HWID-Spoofer");
    Console.WriteLine("Opening directory...");
    Console.WriteLine();
    Console.WriteLine("Execute 'Monotone.exe' now");
    Process.Start("explorer.exe" , @"C:\Monotone-HWID-Spoofer-0.0.1");
    Console.WriteLine("Press any key to exit...");

    Console.ReadKey();
}