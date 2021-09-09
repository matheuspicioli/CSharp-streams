using System;
using System.IO;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            var enderecoDoArquivo = "/home/checklister/dotnet/contas.txt";
            var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);
            byte[] buffer = new byte[1024]; // 1kb

            var numeroDeBytesLidos = -1;

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
            }
            
            Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer)
        {
            foreach (var meuByte in buffer)
            {
                Console.Write(meuByte);
                Console.Write(" ");
            }
        }
    }
}
