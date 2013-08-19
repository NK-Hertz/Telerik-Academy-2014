using System;
using System.IO;
using System.Text;
using System.Security;

/* Write a program that enters file name along with its full file path 
 * (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. 
 * Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all 
 * possible exceptions and print user-friendly error messages.
*/
class ReadFile
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter file path in this format \"c:\\readthis.txt\"  ");
            string path = Console.ReadLine(); //@"c:\readthis.txt"
            string readtext = File.ReadAllText(path);
            Console.WriteLine(readtext);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("You must enter path!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("You must enter a valid path, which doesn`t contain white space, or one or more invalid characters");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine(
                "The specified path, file name, or both exceed the maximum length. The paths must be less than 248 characters, and file names must be less than 260 characters.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive).");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file specified in path was not found.");
        }
        catch (IOException)
        {
            Console.WriteLine("An Input/Output error occurred while opening the file.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("The specified file is read-only");
            Console.WriteLine("or");
            Console.WriteLine("The operation is not supported on the current platform");
            Console.WriteLine("or");
            Console.WriteLine("Path specified a directory");
            Console.WriteLine("or");
            Console.WriteLine("The caller does not have the required permission.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Path is in invalid format.Try using \"c:\\readthis.txt\"");
        }
        catch (SecurityException)
        {
            Console.WriteLine("You don`t have the required permission to access this resource.");
        }


    }
}