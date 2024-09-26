///esta é a classe que gera o menu

using Codelab1.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoUm.Console
{
    public static class Menu
    {
        public static string EscreverMenuString()
        {
            var menu = "-------- Utils Project --------" +
                       " 1 - Abrir calculadora " +
                       " 2 - Abrir navegador " +
                       " 3 - Abrir Bloco de notas" +
                       " 4 - Sair ";
            return menu;
        }
        public static void ExecutarAcao(int acao)
        {
            switch (acao)
            {
                case 1:
                    ExternalCaller.RunCalculator();
                    break;

                case 2:
                    ExternalCaller.RunBrowser("https://yandex.com/?");
                    break;

                case 3:
                    //To do
                    break;

                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
