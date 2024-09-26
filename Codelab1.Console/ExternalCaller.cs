using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codelab1.Console
{
    public static class ExternalCaller
    {
        public static void RunCalculator()
        {
            Process.Start("calc.exe");
        }
        /// <summary>
        /// Abre o navegador padrão com a URL especificada
        /// </summary>
        /// <param name="url"></param>
        public static void RunBrowser(string url) 
        {            
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
    }
}
