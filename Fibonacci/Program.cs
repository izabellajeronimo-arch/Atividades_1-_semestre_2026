// See https://aka.ms/new-console-template for more information
Console.WriteLine("Izabella Neves Pivaro Jeronimo");
Console.OutputEncoding = System.Text.Encoding.UTF8;
//Variáveis
int termos, t1 = 0, t2 = 2, t3 = 4;
Console.WriteLine("Digite o nº de Termos: ");
int.TryParse(Console.ReadLine()!, out termos);
//Console.WriteLine("Digite o nº do Salto: ");
//int.TryParse(Console.ReadLine()!, out salto);
Console.WriteLine($"{t1}👉🏼{t2}👉🏼");
for (int i = 1; i <= termos; i++)
{
    t3 = t1 + t2;
    t1 = t2;
    t2 = t3;
    Console.Write($"{t3}👉🏼");
}
