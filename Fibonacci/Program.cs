// See https://aka.ms/new-console-template for more information
Console.WriteLine("Izabela Neves");
Console.OutputEncoding = System.Text.Encoding.UTF8;
int termos, n1 = 0, n2 = 1, n3 = 0;
Console.Write("Quantos termos?:  ");
int.TryParse(Console.ReadLine()!, out termos);
Console.Write($"{n1},{n2},");
for (int i = 1; i <= termos; i++)
{
    n3 = n1 + n2;
    n1 = n2;
    n2 = n3;

    Console.Write($"{n3}");
}
