//Izabella Neves Pivaro Jeronimo
Console.OutputEncoding = System.Text.Encoding.UTF8;
//Variáveis
int salto, termos, resultado = 0;
Console.Write("Digite o nº de Termos: ");
int.TryParse(Console.ReadLine()!, out termos);
Console.Write("Digite o nº do Salto: ");
int.TryParse(Console.ReadLine()!, out salto);
for (int i = 1; i <= termos; i++);
{
    resultado = resultado + salto;
    Console.Write($"{resultado}");
}

