// See https://aka.ms/new-console-template for more information

// Questão 1
string modo = "";

Console.WriteLine("Digite qual modo você deseja: " +

    "\nopção 1: Fácil" +

    "\nopção 2: Normal" +

    "\nopção 3: Difícil");

modo = Console.ReadLine();

switch (modo)

{

    case "Fácil":

        Console.WriteLine("5 vidas, dano inimigo 10, 3 checkpoints");

        break;

    case "Normal":

        Console.WriteLine("3 vidas, dano inimigo 20, 2 checkpoints");

        break;

    case "Difícil":

        Console.WriteLine("1 vida, dano inimigo 35, 0 checkpoints");

        break;

    default:

        Console.WriteLine("Dificuldade inválida.");

        break;

}

// Questão 2
Console.WriteLine("É sua primeira vez jogando?");
string vez  = Console.ReadLine();
Console.WriteLine("Gostaria de ver o tutorial?");
string tutorial  = Console.ReadLine();
if (vez == "Sim" && tutorial == "Sim")
{
    Console.WriteLine("Iniciando tutorial...");
}
else
{
     Console.WriteLine("Tutorial pulado. Boa sorte!");
}

// Questão 3
Console.WriteLine("Você está escondido?");
string escondido = Console.ReadLine();
Console.WriteLine("Qual nível de barulho feito por você?");
int barulho = int.Parse(Console.ReadLine());
Console.WriteLine("O inimigo está olhando na sua direção?");
string inimigoOlhando = Console.ReadLine();
if (escondido == "não" && inimigoOlhando == "sim" || barulho > 70)
{
    Console.WriteLine("Você foi detectado!");
}
else
{
    Console.WriteLine("Você passou despercebido!");
}

// Questão 4 - crafting de item
Console.WriteLine("Qual quantidade de madeira você possui?");
int madeira = int.Parse(Console.ReadLine());
Console.WriteLine("Qual quantidade de pedra você possui?");
int pedra = int.Parse(Console.ReadLine());
Console.WriteLine("Você possui receita?");
string receita = Console.ReadLine();
if (receita == "sim" && madeira >= 3 && pedra >= 2)
{
    Console.WriteLine("Lança criada com sucesso!");
}
else
{
    Console.WriteLine("Você não possui recurso necessários!");
}

// Questão 5 - sistema de clima
Console.WriteLine("Escolha um clima para sua fase:" +
    "\nopção 1: sol" +
    "\nopção 2: chuva" +
    "\nopção 3: neve " +
    "\nopção 4: tempestade");
string climaEscolhido = Console.ReadLine();
switch (climaEscolhido)
{
    case "sol":
        Console.WriteLine("Velocidade normal");
        break;
    case "chuva":
        Console.WriteLine("Jogador escorrega");
        break;
    case "neve":
        Console.WriteLine("Velocidade reduzida");
        break;
    case "tempestade":
        Console.WriteLine("Vizão reduzida e risco maior");
        break;
    default:
        Console.WriteLine("Clima inválido");
        break;
}

// Questão 6 - diálogo com NPC
Console.WriteLine("Qual é a seu nível de reputação?");
int reputacao = int.Parse(Console.ReadLine());
Console.WriteLine("Você entregou um presente ao NPC?");
string presente = Console.ReadLine();
if (reputacao >= 50 || presente == "sim")
{
    Console.WriteLine("O NPC revelou uma informação secreta");
}
else
{
    Console.WriteLine("O NPC não confia em você ainda");
}

//Questão 7 - puzzle de símbolos
Console.WriteLine("Escolha um símbolo:" +
    "\nopção 1: lua" +
    "\nopção 2: sol" +
    "\nopção 3: estrela" +
    "\nopção 4: chama");
string simboloEscolhido = Console.ReadLine();
switch (simboloEscolhido)
{
    case "lua":
        Console.WriteLine("Uma ponte aparece");
        break;
    case "sol":
        Console.WriteLine("A sala fica iluminada");
        break;
    case "estrela":
        Console.WriteLine("Um item secreto surge");
        break;
    case "chama":
        Console.WriteLine("Uma armadilha é ativada");
        break;
    default:
        Console.WriteLine("Nada aconteceu");
        break;
}

// Questão 8 - câmera de jogo de terror
Console.WriteLine("Quanto você tem de bateria da câmera?");
int bateria = int.Parse(Console.ReadLine());
Console.WriteLine("Existe monstro na tela?");
string monstro = Console.ReadLine();
Console.WriteLine("Você apertou o botão de gravar?");
string gravar = Console.ReadLine();
if (bateria > 0 && monstro == "sim" && gravar == "sim")
{
    Console.WriteLine("Cena assustadora gravada!");
}
else if (bateria > 0 && monstro == "não" && gravar == "sim")
{
    Console.WriteLine("Você gravou mas nada interessante apareceu!");
}
else if (bateria <= 0 && monstro == "sim" && gravar == "sim")
{
    Console.WriteLine("A câmera está sem bateria");
}
else
{
    Console.WriteLine("Você não conseguiu gravar o monstro");
}


// Questão 9
Console.WriteLine("Qual seu nível de energia?");
int energia = int.Parse(Console.ReadLine());
Console.WriteLine("Escolha uma opção do menu de ataque:" +
    "\nopção 1: ataque leve" +
    "\nopção 2: ataque pesado" +
    "\nopção 3: especial" +
    "\nopção 4: esquivar");
string ataqueEscolhido = Console.ReadLine();
switch (ataqueEscolhido)
{
    case "ataque leve":
        if (energia >= 0)
        {
            Console.WriteLine("Ataque leve realizado, não gastou energia.");
        }
        else
        {
            Console.WriteLine("Energia insuficiente para ataque leve!");
        }
        break;
    case "ataque pesado":
        if (energia >= 15)
        {
            Console.WriteLine("Ataque pesado realizado!");
        }
        else
        {
            Console.WriteLine("Energia insuficiente para ataque pesado!");
        }
        break;
    case "especial":
        if (energia >= 30)
        {
            Console.WriteLine("Ataque especial realizado!");
        }
        else
        {
            Console.WriteLine("Energia insuficiente para ataque especial!");
        }
        break;
    case "esquivar":
        if (energia >= 10)
        {
            Console.WriteLine("Você conseguiu esquivar!");
        }
        else
        {
            Console.WriteLine("Energia insuficiente para esquivar!");
        }
        break;
    default:
        Console.WriteLine("Opção inválida!");
        break;
}

//Questão 10
Console.WriteLine("Escolha um tipo de área:" +
    "\nopção 1: Floresta" +
    "\nopção 2: Ruínas" +
    "\nopção 3: Laboratório" +
    "\nopção 4: Praia");
string areaEscolhida = Console.ReadLine();
switch (areaEscolhida)
{
    case "Floresta":
        Console.WriteLine("Você encontrou um animal selvagem");
        break;
    case "Ruínas":
        Console.WriteLine("Uma armadilha antiga foi ativada");
        break;
    case "Laboratório":
        Console.WriteLine("Um robô descontrolado apareceu");
        break;
    case "Praia":
        Console.WriteLine("Tempestade repentina começou");
        break;
    default:
        Console.WriteLine("Área inválida!");
        break;
}
Console.WriteLine("Qual seu nível?");
int nivel = int.Parse(Console.ReadLine());
Console.WriteLine("Você possui um item especial?");
string itemEsp = Console.ReadLine();
Console.WriteLine("Você está acompanhado de um aliado?");
string aliado = Console.ReadLine();
if (nivel >= 5 && itemEsp == "sim" || aliado == "sim")
{
    Console.WriteLine("Você conseguiu resolver o seu evento!");
}
else
{
    Console.WriteLine("Você não estava preparado para este evento!");
}