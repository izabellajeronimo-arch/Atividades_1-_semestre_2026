// Izabella Neves Pivaro Jeronimo
using System.ComponentModel.Design;

Console.OutputEncoding = System.Text.Encoding.UTF8;
//declaração de variáveis locais
Console.WriteLine("Calculadora de IMC");
float imc = 0;
Console.Write("Digite o Peso: ".Replace(".", ","));
float.TryParse(Console.ReadLine()!, out float peso);
Console.Write("Digite a Altura: ".Replace(".", ","));
float.TryParse(Console.ReadLine()!, out float altura);
imc = (float)(peso / Math.Round(Math.Pow(altura, 2), 2));

{
    if (imc < 18.5) Console.WriteLine("Magra");
    else if (imc < 25) Console.WriteLine("Normal");
    else if (imc < 30) Console.WriteLine("Acima do peso");
    else if (imc < 35) Console.WriteLine("Obesa");
    else Console.WriteLine("Obesa");
}

/*
baixo peso (< 18,5) 
normal (18,5–24,9) 
sobrepeso (25–29,9)
obesidade (30) 
obesidade I 30-34,9 
obesidade II 35-39,9 
obesidade III > 40 
*/