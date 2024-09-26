using System.Diagnostics;
namespace Codelab1.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Constantes.HelloWorldMsg);

            ExternalCaller.RunCalculator();
            ExternalCaller.RunBrowser("https://google.com");
        }
    }
}