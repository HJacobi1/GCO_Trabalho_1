using System;
using System.Diagnostics;
namespace TrabalhoUm.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                System.Console.WriteLine(Constantes.HelloWorldMsg);
                System.Console.Write(Menu.EscreverMenuString());
                int.TryParse(System.Console.ReadLine(), out int acao);
              
            System.Console.WriteLine(Constantes.HelloWorldMsgJp);


                Menu.ExecutarAcao(acao);
            }
        }
    }
}
