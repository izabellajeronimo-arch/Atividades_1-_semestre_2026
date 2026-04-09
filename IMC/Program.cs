// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lavrinha Good Vibe");
Console.WriteLine("Calculadora de IMC");
//.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,Criação de Variáveis.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,

float peso, altura, imc = 0;
Console.Write("Digite seu peso: ");
float.TryParse(Console.ReadLine(), out peso);
Console.Write("Digite a sua altura: ");
float.TryParse(Console.ReadLine(),out altura);
imc = (float)(peso / Math.Pow(altura, 2));
//testando a variável com console
Console.WriteLine(imc);