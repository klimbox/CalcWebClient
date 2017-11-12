using System.Diagnostics;
using System.IO;


namespace CalcWebClient
{
    static class Program
   {   
        static void Main(string[] main)
        {
            Process.Start("chrome.exe", "..\\..\\WebCalculator.html"); 
        }
    }
}
