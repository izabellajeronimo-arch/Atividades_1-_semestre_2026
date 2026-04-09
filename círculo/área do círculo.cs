//Izabella Neves Pivaro Jeronimo
using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //Cálculo do Valor do Raio e Trazer o Cálculo da Área do Círculo/
        Console.Write("Digite o valor do raio: ");
        float.TryParse(Console.ReadLine(), out float raio);
        float área = (float)(Math.Pow(raio, 2.0) * (float)Math.PI);
        Console.WriteLine($"O valor da Área é A ={área:F2} ");

        double graus = 30, radianos;
        radianos = graus * (Math.PI / 180);
        Console.WriteLine($"O valor do radianos é {radianos:F4}");
        double cosseno = Math.Cos(radianos);
        cosseno = Math.Cos(radianos);
        Console.WriteLine($"O Cosseno de {graus}° é Cos = {cosseno:F4}");
    }
}