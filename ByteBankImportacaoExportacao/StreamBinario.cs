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
        static void EscritorBinario()
        {
            using (FileStream fs = new FileStream("binario.txt", FileMode.Create))
            using (BinaryWriter conversor = new BinaryWriter(fs))
            {
                conversor.Write(224); // Agência
                conversor.Write(465892); // Conta
                conversor.Write(1050.99); // Saldo
                conversor.Write("Lucas Patricio"); //Titular
            }


        }

        static void LeitorBinario() { 
            using(FileStream fs = new FileStream("binario.txt", FileMode.Open))
            using(BinaryReader leitor = new BinaryReader(fs))
            {
                int numeroAgencia = leitor.ReadInt32();
                int numeroConta = leitor.ReadInt32();
                double saldo = leitor.ReadDouble();
                string nome = leitor.ReadString();

                Console.WriteLine($"Agência {numeroAgencia}\nConta {numeroConta}\nSaldo {saldo}\nNome {nome}");

            }
        
        }


    }
}
