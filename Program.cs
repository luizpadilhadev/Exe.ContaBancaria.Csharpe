using Exe.ContaBancaria;
using System.Globalization;



internal class Program
{
    private static void Main(string[] args)
    {
        Conta conta;

        Console.Write("Entre com o número da conta: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Entre com o titular da conta: ");
        string nome = Console.ReadLine();
        Console.Write("Havera depósito inicial (s/n)? ");
        char resposta = char.Parse(Console.ReadLine());

        if (resposta == 's' || resposta == 'S')
        {
            Console.Write("Entre co o valor de depósito inicial: ");
            double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta = new Conta(numero, nome, depositoInicial);
        }
        else
        {
            conta = new Conta(numero, nome);
        }
        Console.WriteLine();
        Console.WriteLine("Dados da conta: ");
        Console.WriteLine(conta);

        Console.WriteLine();
        Console.WriteLine("Entre um valor para depósito");
        double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Deposito(quantia);
        Console.WriteLine("Dados da conta atualizados: ");
        Console.WriteLine(conta);

        Console.WriteLine();
        Console.WriteLine("Entre um valor para saque: ");
        quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Saque(quantia);
        Console.WriteLine("Dados da conta atualizados: ");
        Console.WriteLine(conta);
    }
}