using System;
using System.Net;

/* Write a program that downloads a file from Internet (e.g.
 * http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. 
 * Find in Google how to download files in C#. Be sure to catch all exceptions 
 * and to free any used resources in the finally block.
 */
class Downloader
{
    static void Main()
    {
        Console.WriteLine("Enter URI(adress) from where you will download: ");
        string url = Console.ReadLine();
        Console.WriteLine("Enter name for your file: ");
        string fileName = Console.ReadLine();
        //using  closes the resource after it`s work is done
        using (WebClient webClient = new WebClient())
        {
            try
            {
                webClient.DownloadFile(url, fileName);
                Console.WriteLine("Download complete!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Either adress parameter is null or filename parameter is null!");
            }
            catch (WebException)
            {
                Console.WriteLine("The URI adress is invalid,filename is null or empty or an error occurred while downloading data!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
            }
        }
        

    }

}