
        // Ativando emojis
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        //Aceitar ponto e vírgula
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        Console.WriteLine("❄️ ❄️ ❄️ ❄️ ❄️ ❄️ ❄️ ❄️ ❄️ ❄️ ❄️ ❄️ ❄️ ❄️");
        Console.WriteLine("--- 🌡️ Conversor de Temperaturas ---");
        Console.WriteLine("🔥 🔥 🔥 🔥 🔥 🔥 🔥 🔥 🔥 🔥 🔥");

    
        Console.WriteLine("Escolha a temperatura que vai digitar");
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Celsius para Fahrenheit");
        Console.WriteLine("2 - Fahrenheit para Celsius");
        Console.WriteLine("3 - Kelvin para Celsius");
        Console.WriteLine("4 - Kelvin para Fahrenheit");
        Console.Write("\nDigite a opção desejada: ");

if (int.TryParse(Console.ReadLine(), out int opcao))
        {
            Console.Write("Digite a temperatura: ");

            if (float.TryParse(Console.ReadLine(), out float temp))
            {
                float resultado = 0;

                switch (opcao)
                {
                    case 1:
                        resultado = (temp * 9 / 5) + 32;
                        Console.WriteLine($"\n🔥 {temp:F2}°C = {resultado:F2}°F");
                        break;

                    case 2:
                        resultado = (temp - 32) * 5 / 9;
                        Console.WriteLine($"\n❄️ {temp:F2}°F = {resultado:F2}°C");
                        break;

                    case 3:
                        resultado = temp - 273.15f;
                        Console.WriteLine($"\n❄️ {temp:F2}K = {resultado:F2}°C");
                        break;

                    case 4:
                        resultado = (temp - 273.15f) * 9 / 5 + 32;
                        Console.WriteLine($"\n🔥 {temp:F2}K = {resultado:F2}°F");
                        break;

                    default:
                        Console.WriteLine("❌ Opção inválida!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("❌ Erro: Digite apenas números para a temperatura!");
            }
        }
        else
        {
            Console.WriteLine("❌ Erro: Digite um número válido para a opção!");
        }

        Console.WriteLine("\nPressione Enter para sair...");
        Console.ReadLine();
