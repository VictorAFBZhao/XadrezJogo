using tabuleiro;
using xadrez;
using xadrez_Console;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos);

            Console.ReadLine();
        }
    }
}