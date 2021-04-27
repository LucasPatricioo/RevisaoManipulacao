using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        public static void LidandoComFileStreamDiretamente() {
            string localArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(localArquivo, FileMode.Open))
            {
                byte[] buffer = new byte[1024]; //1kb
                int numeroRetornado = -1;


                while (numeroRetornado != 0)
                {
                    numeroRetornado = fluxoDoArquivo.Read(buffer, 0, 1024);
                    MostrarNaTela(buffer, numeroRetornado);
                }
            }
        }
        public static void MostrarNaTela(byte[] buffer, int bytesLidos)
        {
            var utf8 = new UTF8Encoding();
            string texto = utf8.GetString(buffer, 0, bytesLidos);

            Console.WriteLine(texto);

            //foreach(var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.Write(" ");
            //}
        }

    }
}