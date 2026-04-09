//Izabella Neves Pivaro Jeronimo
Console.OutputEncoding = System.Text.Encoding.UTF8;
//declaração de variáveis úteis
float moeda, conversorReal, Resultado;
int escolha;
Console.WriteLine("Conversor de Moedas");
Console.Write("Digite o Valor em Reais que você quer converter: ");
float.TryParse(Console.ReadLine()!, out moeda);
Console.WriteLine("\nDigite 1 para converter para dólar\n" + "Digite 2 para converter para Libras \n" + "Digite 3 para converter para Euro");
int.TryParse(Console.ReadLine(), out escolha);

switch(escolha){
    case 1:
        Console.Write("Digite o valor do Dólar:  ");
        float.TryParse(Console.ReadLine()!.Replace(".", ","), out conversorReal);
        Resultado = moeda * conversorReal;
        Console.WriteLine($"R${moeda} X U${conversorReal} = R${Resultado}");
        break;

    case 2:
        Console.Write("Digite o valor da Libra:  ");
        float.TryParse(Console.ReadLine()!.Replace(".", ","), out conversorReal);
        Resultado = moeda * conversorReal;
        Console.WriteLine($"R${moeda} X U${conversorReal} = R${Resultado}");
        break;

      case 3:
        Console.Write("Digite o valor do Euro:  ");
        float.TryParse(Console.ReadLine()!.Replace(".", ","), out conversorReal);
        Resultado = moeda * conversorReal;
        Console.WriteLine($"R${moeda} X U${conversorReal} = R${Resultado}");
        break;

    case 4:
        Console.Write("Digite o valor do Iene:  ");
        float.TryParse(Console.ReadLine()!.Replace(".", ","), out conversorReal);
        Resultado = moeda * conversorReal;
        Console.WriteLine($"R${moeda} X U${conversorReal} = R${Resultado}");
        break;
    default:
        Console.WriteLine("Digite um valor válido");
        break;

}

