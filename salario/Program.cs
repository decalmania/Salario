// See https://aka.ms/new-console-template for more information
class URI
{

    static void Main(string[] args)
    {

        string nome = (Console.ReadLine());
        double salario = double.Parse(Console.ReadLine());
        double totalVenda = double.Parse(Console.ReadLine());
        double total = (0.15 * totalVenda) + salario;
        Console.WriteLine("TOTAL = R$ " + total.ToString("F2"));
    }

}
