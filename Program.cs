namespace CheckPoint1;

internal static class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== CHECKPOINT 1 - FUNDAMENTOS C# - Turma  3ESPY ===\n");

        // ENTREGA ATÉ DIA 08/09 AS 23:59
        // Você deve criar um repositório público ou branch no github e me enviar o link pelo
        // teams antes do fim do prazo.
        // IMPORTANTE:
        // - Não haverá reposição do checkpoint.
        // - Fique atento ao prazo, nenhum trabalho será aceito após a data e vou me basear
        // - O link do seu git deve ser enviado no teams. A data e hora do recebimento do git será utilizada para verificar se foi enviado no prazo.
        // 
        // TODO: Implemente as chamadas de teste para demonstrar funcionamento
        // NÃO é obrigatório testar todos os caminhos/casos - apenas mostrar que funciona
        // Use valores de teste simples para validar cada implementação
        //  Treinem rodar o debugger.
        //  F9 - Coloca o breakpoint
        //  F10 - Passa sobre o método no passo a passo
        //  F11 - Entra nos métodos no passo a passo
        //  shift  + F11 - Volta do método

        Console.WriteLine("1. Testando DemonstrarTiposDados...");
        Console.WriteLine(DemonstrarTiposDados());

        Console.WriteLine("\n2. Testando CalculadoraBasica (SWITCH)...");
        Console.WriteLine(CalculadoraBasica(10, 5, '+'));
        Console.WriteLine(CalculadoraBasica(10, 5, '-'));
        Console.WriteLine(CalculadoraBasica(10, 5, '*'));
        Console.WriteLine(CalculadoraBasica(10, 5, '/'));
        Console.WriteLine(CalculadoraBasica(10, 5, '!!!'));

        Console.WriteLine("\n3. Testando ValidarIdade (IF/ELSE)...");
        Console.WriteLine(ValidarIdade(25));

        Console.WriteLine("\n4. Testando ConverterString...");
        Console.WriteLine(ConverterString("123", "int"));

        Console.WriteLine("\n5. Testando ClassificarNota (SWITCH)...");
        Console.WriteLine(ClassificarNota(8.5));

        Console.WriteLine("\n6. Testando GerarTabuada (FOR)...");
        Console.WriteLine(GerarTabuada(5));

        Console.WriteLine("\n7. Testando JogoAdivinhacao (WHILE)...");
        Console.WriteLine(JogoAdivinhacao(50, new int[] { 25, 75, 50 }));

        Console.WriteLine("\n8. Testando ValidarSenha (DO-WHILE)...");
        Console.WriteLine(ValidarSenha("MinhaSenh@123"));

        Console.WriteLine("\n9. Testando AnalisarNotas (FOREACH)...");
        Console.WriteLine(AnalisarNotas(new double[] { 8.5, 7.0, 9.2, 6.5, 10.0 }));

        Console.WriteLine("\n10. Testando ProcessarVendas (FOREACH múltiplo)...");
        Console.WriteLine(ProcessarVendas(
            new double[] { 1000, 500, 2000 },
            new string[] { "A", "B", "A" },
            new double[] { 0.1, 0.07, 0.05 },
            new string[] { "A", "B", "C" }));

        Console.WriteLine("\n=== RESUMO: TODAS AS ESTRUTURAS FORAM TESTADAS ===");
        Console.WriteLine("✅ IF/ELSE: Testado na validação de idade");
        Console.WriteLine("✅ SWITCH: Testado na calculadora e classificação de notas");
        Console.WriteLine("✅ FOR: Testado na tabuada");
        Console.WriteLine("✅ WHILE: Testado no jogo de adivinhação");
        Console.WriteLine("✅ DO-WHILE: Testado na validação de senha");
        Console.WriteLine("✅ FOREACH: Testado na análise de notas e processamento de vendas");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    // =====================================================================
    // QUESTÃO 1 - VARIÁVEIS E TIPOS DE DADOS (10 pontos)
    // =====================================================================
    private static string DemonstrarTiposDados()
    {
        int inteiro = 42;
        double decimalNum = 3.14;
        bool booleano = true;
        char caractere = 'A';
        string texto = "Olá";
        var outro = 99;
        return $"Inteiro: {inteiro}, Decimal: {decimalNum}, Booleano: {booleano}, Caractere: {caractere}, Texto: {texto}, Outro: {outro}";
    }

    // =====================================================================
    // QUESTÃO 2 - OPERADORES ARITMÉTICOS (10 pontos)
    // =====================================================================
    private static double CalculadoraBasica(double num1, double num2, char operador)
    {
        switch (operador)
        {
            case '+': return num1 + num2;
            case '-': return num1 - num2;
            case '*': return num1 * num2;
            case '/': return num2 == 0 ? 0 : num1 / num2;
            default: return -1;
        }
    }

    // =====================================================================
    // QUESTÃO 3 - OPERADORES RELACIONAIS E LÓGICOS (10 pontos)  
    // =====================================================================
    private static string ValidarIdade(int idade)
    {
        if (idade < 0 || idade > 120) return "Idade inválida";
        else if (idade < 12) return "Criança";
        else if (idade < 18) return "Adolescente";
        else if (idade <= 65) return "Adulto";
        else return "Idoso";
    }

    // =====================================================================
    // QUESTÃO 4 - CONVERSÃO DE TIPOS (10 pontos)
    // =====================================================================
    private static string ConverterString(string valor, string tipoDesejado)
    {
        if (tipoDesejado == "int")
        {
            if (int.TryParse(valor, out int n)) return $"int: {n}";
            return "Conversão impossível para int";
        }
        else if (tipoDesejado == "double")
        {
            if (double.TryParse(valor, out double d)) return $"double: {d}";
            return "Conversão impossível para double";
        }
        else if (tipoDesejado == "bool")
        {
            if (bool.TryParse(valor, out bool b)) return $"bool: {b}";
            return "Conversão impossível para bool";
        }
        return "Tipo inválido";
    }

    // =====================================================================
    // QUESTÃO 5 - ESTRUTURA CONDICIONAL SWITCH (10 pontos)
    // =====================================================================
    private static string ClassificarNota(double nota)
    {
        switch (nota)
        {
            case >= 9.0 and <= 10.0: return "Excelente";
            case >= 7.0 and < 9.0: return "Bom";
            case >= 5.0 and < 7.0: return "Regular";
            case >= 0.0 and < 5.0: return "Insuficiente";
            default: return "Nota inválida";
        }
    }

    // =====================================================================
    // QUESTÃO 6 - ESTRUTURA FOR (10 pontos)
    // =====================================================================
    private static string GerarTabuada(int numero)
    {
        if (numero <= 0) return "Número inválido";
        string resultado = "";
        for (int i = 1; i <= 10; i++)
        {
            resultado += $"{numero} x {i} = {numero * i}\n";
        }
        return resultado;
    }

    // =====================================================================
    // QUESTÃO 7 - ESTRUTURA WHILE (15 pontos)
    // =====================================================================
    private static string JogoAdivinhacao(int numeroSecreto, int[] tentativas)
    {
        string resultado = "";
        int i = 0;
        while (i < tentativas.Length)
        {
            int palpite = tentativas[i];
            if (palpite < numeroSecreto) resultado += $"Tentativa {i + 1}: {palpite} - muito baixo\n";
            else if (palpite > numeroSecreto) resultado += $"Tentativa {i + 1}: {palpite} - muito alto\n";
            else { resultado += $"Tentativa {i + 1}: {palpite} - correto!\n"; break; }
            i++;
        }
        return resultado;
    }

    // =====================================================================
    // QUESTÃO 8 - ESTRUTURA DO-WHILE (15 pontos)
    // =====================================================================
    private static string ValidarSenha(string senha)
    {
        bool valido = false;
        string erros = "";
        do
        {
            if (senha.Length < 8) erros += "Mínimo 8 caracteres\n";
            if (!senha.Any(char.IsDigit)) erros += "Precisa de número\n";
            if (!senha.Any(char.IsUpper)) erros += "Precisa de maiúscula\n";
            if (!senha.Any(c => "!@#$%&*".Contains(c))) erros += "Precisa de especial\n";
            valido = erros == "";
        } while (false);
        return valido ? "Senha válida" : erros;
    }

    // =====================================================================
    // QUESTÃO 9 - ESTRUTURA FOREACH (15 pontos)
    // =====================================================================
    private static string AnalisarNotas(double[] notas)
    {
        if (notas == null || notas.Length == 0) return "Nenhuma nota para analisar";
        double soma = 0, maior = double.MinValue, menor = double.MaxValue;
        int aprovados = 0, A = 0, B = 0, C = 0, D = 0, F = 0;
        foreach (var n in notas)
        {
            soma += n;
            if (n > maior) maior = n;
            if (n < menor) menor = n;
            if (n >= 7) aprovados++;
            if (n >= 9) A++;
            else if (n >= 8) B++;
            else if (n >= 7) C++;
            else if (n >= 5) D++;
            else F++;
        }
        double media = soma / notas.Length;
        return $"Média: {media}\nAprovados: {aprovados}\nMaior: {maior}\nMenor: {menor}\nA: {A}, B: {B}, C: {C}, D: {D}, F: {F}";
    }

    // =====================================================================
    // QUESTÃO 10 - MULTIPLE FOREACH (DESAFIO) (20 pontos)
    // =====================================================================
    private static string ProcessarVendas(double[] vendas, string[] categorias, double[] comissoes, string[] nomesCategorias)
    {
        var totais = new Dictionary<string, double>();
        var ganhos = new Dictionary<string, double>();
        for (int i = 0; i < categorias.Length; i++)
        {
            string cat = categorias[i];
            double venda = vendas[i];
            double perc = 0;
            foreach (var nome in nomesCategorias.Select((v, idx) => new { v, idx }))
            {
                if (nome.v == cat) perc = comissoes[nome.idx];
            }
            if (!totais.ContainsKey(cat)) { totais[cat] = 0; ganhos[cat] = 0; }
            totais[cat] += venda;
            ganhos[cat] += venda * perc;
        }
        string resultado = "";
        foreach (var cat in totais.Keys)
        {
            resultado += $"Categoria {cat}: Vendas R$ {totais[cat]:F2}, Comissão R$ {ganhos[cat]:F2}\n";
        }
        return resultado;
    }

    // =====================================================================
    // MÉTODOS AUXILIARES (NÃO ALTERAR - APENAS PARA REFERÊNCIA)
    // =====================================================================
    private static void ExemploMetodoEstatico()
    {
        Console.WriteLine("Sou um método estático - chamado direto da classe");
    }

    /*
    void ExemploMetodoInstancia()
    {
        Console.WriteLine("Sou um método de instância - preciso de um objeto para ser chamado");
    }
    */
}
