
using Microsoft.Win32;
using System;

class Program
{
    static void Main()
    {
        var subKeyNames = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");

        Console.WriteLine(subKeyNames);
        string[] valueNames = subKeyNames.GetValueNames();
        foreach (var item in valueNames)
        {
            Console.WriteLine(item);
            string value = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", item, null);
            Console.WriteLine(value);
            Console.WriteLine((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", item, null));
        }
    }
}