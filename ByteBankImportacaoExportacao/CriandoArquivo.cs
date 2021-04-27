using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ByteBankImportacaoExportacao.Modelos;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriarArquivo() {
            string caminhoDoArquivo = "contasExportadas.csv";

            using (var fluxoDeDados = new FileStream(caminhoDoArquivo, FileMode.Create))
            {
                string conta = "222,242442,850.69,Lucas Patricio";
                Encoding encoding = Encoding.UTF8;

                byte[] conversao = encoding.GetBytes(conta);

                fluxoDeDados.Write(conversao, 0, conversao.Length);
            }
        }
        static void CriarArquivoStream() {
            string caminhoDoArquivo = "contasExportadas.csv";

            using(FileStream fluxoDeArquivo = new FileStream(caminhoDoArquivo, FileMode.Create))
            using(StreamWriter escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
            {
                escritor.Write("242,442435,850.00,Lucas Patricio");
            }
        }
    }
}
