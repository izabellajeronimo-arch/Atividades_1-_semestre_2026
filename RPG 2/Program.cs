//Izabella Neves Pivaro Jeronimo
using System;
using System.Globalization;


    {
        // Garante que o ponto decimal funcione em qualquer computador
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("--- 🐉 TRIAGEM DA GUILDA: DESAFIO DO DRAGÃO ---");

        // --- ENTRADA DE DADOS COM TRATAMENTO DE NULOS ---

        Console.Write("Nome do Herói: ");
        // O ?? "" garante que se o ReadLine for nulo, a variável recebe texto vazio
        string nome = Console.ReadLine() ?? "Herói Sem Nome";

        Console.Write("Classe (Mago, Clérigo, Guerreiro, Druida, Anão, Elfo ou Troll): ");
        string classeInput = Console.ReadLine() ?? "";
        string classe = classeInput.Trim().ToLower();

        Console.Write("Nível: ");
        string nivelInput = Console.ReadLine() ?? "0";
        int nivel = int.Parse(nivelInput);

        Console.Write("Pontos de Vida (HP): ");
        string hpInput = Console.ReadLine() ?? "0";
        double hp = double.Parse(hpInput);

        Console.Write("Pontos de Magia (Mana): ");
        string manaInput = Console.ReadLine() ?? "0";
        int mana = int.Parse(manaInput);

        Console.Write("Ouro na mochila: ");
        string ouroInput = Console.ReadLine() ?? "0";
        double ouro = double.Parse(ouroInput);

        Console.WriteLine("\n--- 🛡️ PROCESSANDO RESULTADOS ---");

        // 1. REGRA DA RAÇA INIMIGA
        if (classe != "troll" && !(nivel < 5))
        {
            Console.WriteLine($"{nome} foi aceito para avaliação!");
        }
        else
        {
            Console.WriteLine("❌ ACESSO NEGADO! Trolls ou heróis abaixo do nível 5 não entram.");
            return;
        }

        // 2. CÁLCULO DO PODER DE COMBATE
        double poderBase = (nivel * 10) + (hp / 2) - 5;
        Console.WriteLine($"Poder Base: {poderBase}");

        // 3. REGRA DO DANO CRÍTICO
        if (poderBase % 2 == 0)
        {
            Console.WriteLine("⚔️✨ BÔNUS: Ataque Crítico disponível!");
        }

        // 4. LÓGICA DE COMBATE
        bool podeAtacar = false;

        if (classe == "mago" || classe == "druida" || classe == "clérigo" || classe == "clerigo")
        {
            if (mana >= 30 && nivel <= 100) podeAtacar = true;
        }
        else if (classe == "guerreiro" || classe == "anão" || classe == "anao" || classe == "elfo")
        {
            if (hp > 20 && poderBase > 50) podeAtacar = true;
        }

        // --- RESULTADO FINAL ---
        if (podeAtacar)
        {
            Console.WriteLine($"\n✅ {nome} está pronto para lutar!");
        }
        else
        {
            if (ouro > 1000 || classe == "anão" || classe == "anao")
            {
                Console.WriteLine($"\n💰 {nome} não pode lutar, mas subornou o Dragão!");
            }
            else
            {
                Console.WriteLine($"\n🔥 {nome} virou churrasco!");
            }
        }
    }
