//Izabella Neves Pivaro Jeronimo
Console.Write("Digite o valor de dinheiro que você vai emprestar R$: ");
double capital = Convert.ToDouble(Console.ReadLine());
Console.Write("Taxa de juros (% ao mês): ");
double taxa = Convert.ToDouble(Console.ReadLine());
Console.Write(" Quantidade dos Meses: ");
int tempo = Convert.ToInt32(Console.ReadLine());

if (capital > 0 && taxa > 0 && tempo > 0)
{
    double juros = capital * (taxa / 100) * tempo;
    double total = capital + juros;

    Console.WriteLine($"\nJuros: R$ {juros:F2}");
    Console.WriteLine($" Total a pagar: R$ {total:F2}");
    if (juros > capital * 0.5)
    {
        Console.WriteLine("\n⚠️ CUIDADO: Os juros são mais da metade do valor emprestado!");
    }
    else
    {
        Console.WriteLine("\n👍 Negócio dentro do normal.");
    }
}
else
{
    Console.WriteLine("\n❌ ERRO: Todos os valores devem ser positivos!");
}