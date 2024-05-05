namespace pilhaFibonacci;

internal class Program
{
    private static void Main(string[] args)
    {
        int recomeço = 0, numero = 1, ultimo = 1, penultimo = -1, atual = 0;
        numeroPilha pilha = new();

        do
        {
            ultimo = 1;
            penultimo = -1;
            atual = 0;

            do
            {
                Console.Clear();

                if (numero <= 0) Console.WriteLine("ERRO: Informe um número maior que 0");

                Console.Write("Informe quantos números da sequência fibonacci você deseja adicionar na pilha:");
                numero = int.Parse(Console.ReadLine());
            } while (numero <= 0);

            for (int i = 0; i < numero; i++)
            {
                atual = ultimo + penultimo;
                pilha.Push(new Numero(atual));
                penultimo = ultimo;
                ultimo = atual;
            }

            pilha.Print();

            Console.WriteLine("\nDeseja reiniciar o programa?");
            Console.WriteLine("1 - SIM");
            Console.WriteLine("0 - NAO");
            recomeço = int.Parse(Console.ReadLine());
            if (recomeço != 0) pilha = new();
        } while (recomeço != 0);
    }
}