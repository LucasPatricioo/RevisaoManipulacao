using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void StreamEntrada()
        {

            using (var entrada = Console.OpenStandardInput())
            using (FileStream fs = new FileStream("StreamConsole.txt", FileMode.Create))
            {
                int numero = 0;
                byte[] buffer = new byte[1024];


                while (numero != 10)
                {
                    var bytesLidos = entrada.Read(buffer, 0, 1024);
                    fs.Write(buffer, 0, bytesLidos);
                    fs.Flush();
                }
            }

        }






    }
}
