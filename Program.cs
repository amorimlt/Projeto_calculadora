
string operacaoEscolhida;

Console.Clear();//limpa a tela

Console.BackgroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("│― Calculadora das 11 operações LYA ―│\n");
Console.ResetColor();

Console.WriteLine("│― 1 Soma");
Console.WriteLine("│― 2 Subtração");
Console.WriteLine("│― 3 Multiplicação");
Console.WriteLine("│― 4 Divisão");
Console.WriteLine("│― 5 Exponenciação");
Console.WriteLine("│― 6 Radiciação");
Console.WriteLine("│― 7 Média aritmética");
Console.WriteLine("│― 8 Graus °C para °F");
Console.WriteLine("│― 9 Graus °F para °C");
Console.WriteLine("│― 10 Velocidade média");
Console.WriteLine("│― 11 Bhaskara");
//menu de operacoes

Console.Write("\nDigite o n° da operação almejada: ");

operacaoEscolhida = Console.ReadLine()!;

switch (operacaoEscolhida) //Estrutura que possibilita o usuario a escolher a operacao almejada
{
    case "1":
        CalcularSoma();
        break;
    case "2":
        CalcularSubtracao();
        break;
    case "3":
        CalcularMultiplicacao();
        break;
    case "4":
        CalcularDivisao();
        break;
    case "5":
        CalcularExpoente();
        break;
    case "6":
        CalcularRadiciacao();
        break;
    case "7":
        CalcularMedia();
        break;
    case "8":
        CalcularCF();
        break;
    case "9":
        CalcularFC();
        break;
    case "10":
        CalcularVelocidadeM();
        break;
        case "11":
        CalcularBhaskara();
        break;
    default:
        Console.WriteLine("Opção inexistente.");
        break;
}

Console.WriteLine("\nAgradecemos por utilizar a LYA!.");


//inicia codigo das operacoes

void CalcularSoma()
{
    double a, b, resultado;

        Console.BackgroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("\r\n │- Soma dois algoritimos -│"); Console.ResetColor();
        
    Console.WriteLine("Digite os valores:");

    Console.Write("1° numero = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("2° numero  = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a + b;

    Console.WriteLine($"O resultado da soma de {a} com {b} é {resultado}");

    Console.WriteLine("\nClique em uma tecla para sair...");
    Console.ReadKey();

    return;
}

void CalcularSubtracao()
{
    double a, b, resultado;

         Console.BackgroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("\r\n│- Subtrai dois algoritimos -│"); Console.ResetColor();
    Console.WriteLine("Digite os valores:");

    Console.Write("1° numero = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("2° numero = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a - b;

    Console.WriteLine($"O resultado da subtracao de {a} com {b} é {resultado}");

    Console.WriteLine("\nClique em uma tecla para sair...");
    Console.ReadKey();

    return;
}

void CalcularMultiplicacao()
{
    double a, b, resultado;

         Console.BackgroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("\r\n│- Multiplica dois algoritimos -│"); Console.ResetColor();
    Console.WriteLine("Digite os valores:");

    Console.Write("1° numero = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("2° numero = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a * b;

    Console.WriteLine($"\nO resultado da multiplicacao de {a} com {b} é {resultado}");

    Console.WriteLine("\nClique em uma tecla para sair...");
    Console.ReadKey();

    return;
}

void CalcularDivisao()
{
    double a, b, resultado;

         Console.BackgroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("\r\n│- Divide dois algoritimos -│"); Console.ResetColor();
    Console.WriteLine("Digite os valores:");

    Console.Write("1° numero = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("2° numero = ");
    b = Convert.ToDouble(Console.ReadLine());

    if (b == 0)
    {
        Console.WriteLine("\nNão é possível fazer uma divisao por zero.");
    }
    else
    {
        resultado = a / b;

        Console.WriteLine($"O resultado da divisao de {a} com {b} é {resultado}");
    }

    Console.WriteLine("\nClique em uma tecla para sair...");
    Console.ReadKey();

    return;
}

void CalcularExpoente()
{
    double a, b, resultado;

         Console.BackgroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("\r\n│- Expoenciacao -│"); Console.ResetColor();
    Console.WriteLine("Digite os valores:");

    Console.Write("1° numero = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("2° numero = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = Math.Pow(a,b);

    Console.WriteLine($"{a} elevado a {b} é {resultado}");

    Console.WriteLine("\nClique em uma tecla para sair...");
    Console.ReadKey();

    return;
}

void CalcularRadiciacao()
{
    double radicando, indice;

         Console.BackgroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("\r\n│- Radiciacao -│"); Console.ResetColor();
    Console.WriteLine("Digite os valores:");

    Console.Write("Radicando = ");
    radicando = Convert.ToDouble(Console.ReadLine());
    Console.Write("Indice = ");
    indice = Convert.ToDouble(Console.ReadLine());

    if (radicando < 0)
    {
        throw new Exception("O radicando deve ser maior ou igual a zero"); //adicionou uma excecao
    }
    else if (indice <= 0)
    {
        throw new Exception("O indice deve ser maior que zero");
    }
    else
    {
        double raiz = Math.Pow(radicando, 1/ indice);
        Console.WriteLine($"a raíz {radicando} de {indice} é {raiz}");
    }

    Console.WriteLine("\nClique em uma tecla para sair...");
    Console.ReadKey();

    return;
}

void CalcularMedia()
{
     double nota1, nota2, nota3, resultado;

         Console.BackgroundColor = ConsoleColor.DarkMagenta;
     Console.WriteLine("\r\n│- Média Aritmética de 3 números -│"); Console.ResetColor();

     Console.Write("Digite o 1° número..: ");
     nota1 = Convert.ToDouble(Console.ReadLine());

     Console.Write("Digite o 2° número...: ");
     nota2 = Convert.ToDouble(Console.ReadLine());

     Console.Write("Digite o 3° número..: ");
     nota3 = Convert.ToDouble(Console.ReadLine());

     resultado = (nota1 + nota2 + nota3) / 3;

     Console.WriteLine($"\nMédia: {resultado:N1}");

     Console.WriteLine($"A media de {nota1},{nota2} e {nota3} é {resultado}");

    Console.WriteLine("\nClique em uma tecla para sair...");
    Console.ReadKey();

    return;
    }

    void CalcularCF()
{
         Console.BackgroundColor = ConsoleColor.DarkMagenta;
     Console.WriteLine("\r\n│- Conversão de °C para °F -│"); Console.ResetColor();

     Console.Write("Digite a temperatura em graus Celsius: ");
     double tempC = Convert.ToDouble(Console.ReadLine());

     double tempF = tempC * 1.8 + 32;

     Console.WriteLine($"{tempC}°C equivalem a {tempF:N2}°F");

    Console.WriteLine("\nClique em uma tecla para sair...");
    Console.ReadKey();

    return;
    }

    void CalcularFC()
{
         Console.BackgroundColor = ConsoleColor.DarkMagenta;
     Console.WriteLine("\r\n│- Conversão de °F para °C -│"); Console.ResetColor();

     Console.Write("Digite a temperatura em graus Fahrenheit: ");
     double tempF = Convert.ToDouble(Console.ReadLine());

     double tempC = (tempF - 32) / 1.8;

     Console.WriteLine($"{tempF}°F equivalem a {tempC:N2}°C");

    Console.WriteLine("\nClique em uma tecla para sair...");
    Console.ReadKey();

    return;
    }

    void CalcularVelocidadeM()
    {
         double distancia, tempo, velocidade;

             Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("\r\n│- Velocidade média -│"); Console.ResetColor();

        Console.Write("Distância percorrida (m): ");
        distancia = Convert.ToDouble(Console.ReadLine());
            
        Console.Write("Tempo gasto (s): ");
        tempo = Convert.ToDouble(Console.ReadLine());

        velocidade = distancia / tempo;

        Console.WriteLine($"\nVelocidade média: {velocidade:N2} m/s");

    Console.WriteLine("\nClique em uma tecla para sair...");
    Console.ReadKey();

    return;
        }

    void CalcularBhaskara()

    { double a, b, c, delta, x1, x2;

             Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("\r\n│- Equação do segundo grau -│"); Console.ResetColor();

        Console.Write("(1° numero): ");
        a = Convert.ToDouble(Console.ReadLine());

         Console.Write("(2° numero): ");
         b = Convert.ToDouble(Console.ReadLine());

        Console.Write("(3° numero): ");
        c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();

            if (a == 0)
            {
                Console.WriteLine("Não é uma equação de segundo grau!");
            }
            else
            {
                delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    Console.WriteLine($"Como delta = {delta:N2}, a equação não possui raízes reais!");
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine($"x1 = {x1:N2} e x2 = {x2:N2}");}

        Console.WriteLine("\nClique em uma tecla para sair...");
        Console.ReadKey();
            }
            return;
        }    



