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
        static void Main(string[] args)
        {
            string localArquivo = "contas.txt";

            using (var fluxoDeArquivos = new FileStream(localArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivos))
            {
                while (!leitor.EndOfStream)
                {
                    string linha = leitor.ReadLine();
                    Console.WriteLine(linha);
                }
            }
        }
    }
}
