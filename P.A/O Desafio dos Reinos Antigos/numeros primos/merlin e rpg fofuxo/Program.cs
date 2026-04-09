// See https://aka.ms/new-console-template for more information

using System;

    Console.WriteLine("O Mago Merlin precisa de um programa que calcule por 3 vezes a área de um quadrado");
for (int i = 0; i < 3; i++)
{
    int.TryParse(Console.ReadLine(), out int lado);
    int area = lado * lado;
    Console.WriteLine($"area: {area}");
}
Console.WriteLine("O Deus da profanidade Infofoxu lançou um feitiço." +
    "\nVocê deve combate-lo fazendo um circulo de proteção divina" +
    "\nPara isso você deve digitar um raio e calcular a área da circunferência");
Console.WriteLine("Digite o número do raio");
int.TryParse(Console.ReadLine(), out int raio);
float circulo = (raio * raio) * 3.14f;
if (circulo < 10)
{
    Console.WriteLine("Você perdeu!");
}

else
{
    Console.WriteLine("Você ganhou");
}
