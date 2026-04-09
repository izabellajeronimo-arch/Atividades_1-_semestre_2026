//Izabella Neves Pivaro Jeronimo
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("digitar um numero limite");
int cont = 0;
int.TryParse(Console.ReadLine(), out int primo);
for (int i = 1; i <= primo; i++)
{
    if (primo % i == 0)
    {
        cont++;
    }
    Console.Write($"{i} ➡️");
}
Console.Write("😍");
if (cont == 2)
{
    Console.WriteLine($"\n o numero {primo} é primo");
}
else
{
    Console.WriteLine($"\n o numero {primo} nao é primo");
}

