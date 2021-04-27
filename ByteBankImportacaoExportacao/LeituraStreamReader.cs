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
        static void Leitor()
        {
            using (var fluxoDeArquivos = new FileStream(localArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivos))
            {
                while (!leitor.EndOfStream)
                {
                    string linha = leitor.ReadLine();
                    ContaCorrente conta = ConverterArquivo(linha);
                    Console.WriteLine($"Nome do titular: {conta.Titular.Nome} / Numero da conta: {conta.Numero} / Ag. {conta.Agencia} / Saldo: {conta.Saldo}");
                }
            }
        }
        static ContaCorrente ConverterArquivo(string linha)
        {
            string[] linhaRecebida = linha.Split(',');

            int agencia = int.Parse(linhaRecebida[0]);
            int numero = int.Parse(linhaRecebida[1]);
            double saldo = double.Parse(linhaRecebida[2].Replace('.', ','));
            string nome = linhaRecebida[3];

            Cliente titular = new Cliente();
            titular.Nome = nome;

            var conta = new ContaCorrente(agencia, numero);
            conta.Depositar(saldo);
            conta.Titular = titular;

            return conta;
        }
    }
}
