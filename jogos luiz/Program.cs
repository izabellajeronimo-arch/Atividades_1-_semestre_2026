
// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;
for (int i = 0; i < 7; i++)
{
    Console.WriteLine("Escreva um número para exibir um tipo de fóssil: ");
    int.TryParse(Console.ReadLine(), out int opção);
    switch (opção)
    {
        case (1):
            Console.WriteLine("poriferos");
            break;
        case (2):
            Console.WriteLine("cnidários");
            break;
        case (3):
            Console.WriteLine("platelmintos");
            break;
        case (4):
            Console.WriteLine("moluscos");
            break;
        case (5):
            Console.WriteLine("anelídeos");
            break;
        case (6):
            Console.WriteLine("artrópodes");
            break;
        case (7):
            Console.WriteLine("urocordados");
            break;
        default:
            Console.WriteLine("Digite uma opção válida");
            break;
    }
}