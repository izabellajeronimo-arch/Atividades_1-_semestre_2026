Console.OutputEncoding = System.Text.Encoding.UTF8;
//Declarar variáveis
int contador = 0, resultado;
Console.WriteLine("Calculadora de Números Primos");
Console.Write("Digite o Número: ");
//int.TryParse(Console.ReadLine(), out int primo);
int primo = 7;
for (int i = 1; i <= primo; i++)
{
    if(primo% 6== 0)
    {

        contador++;
        Console.Write($"(i)");
    }
    
}
