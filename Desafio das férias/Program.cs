// See https://aka.ms/new-console-template for more information

// Ex 1
string nome;
string classe;
int vida;
int forca;
int energia;

Console.WriteLine("=== CRIACAO DE PERSONAGEM ===");

Console.WriteLine("Digite o nome do personagem:");
nome = Console.ReadLine();

Console.WriteLine("Escolha a classe:");
Console.WriteLine("1 - Guerreiro");
Console.WriteLine("2 - Mago");
Console.WriteLine("3 - Arqueiro");
classe = Console.ReadLine();

if (classe == "1")
{
    vida = 120;
    forca = 15;
    energia = 60;
}
else if (classe == "2")
{
    vida = 80;
    forca = 8;
    energia = 150;
}
else
{
    vida = 100;
    forca = 12;
    energia = 100;
}

Console.WriteLine("=== FICHA ===");
Console.WriteLine("Nome: " + nome);
Console.WriteLine("Classe: " + classe);
Console.WriteLine("Vida: " + vida);
Console.WriteLine("Forca: " + forca);
Console.WriteLine("Energia: " + energia);

// Ex 2
string[] nomes = { "Floresta", "Caverna", "Castelo" };
string[] dificuldades = { "Facil", "Medio", "Dificil" };
string[] descricoes = { "Floresta perigosa", "Caverna escura", "Castelo do chefe" };

string escolha;

Console.WriteLine("=== FASES ===");

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(nomes[i]);
    Console.WriteLine(dificuldades[i]);
    Console.WriteLine(descricoes[i]);
}

Console.WriteLine("Escolha uma fase:");
escolha = Console.ReadLine();

switch (escolha)
{
    case "1":
        Console.WriteLine("Voce escolheu a Floresta!");
        break;

    case "2":
        Console.WriteLine("Voce escolheu a Caverna!");
        break;

    case "3":
        Console.WriteLine("Voce escolheu o Castelo!");
        break;

    default:
        Console.WriteLine("Fase invalida.");
        break;
}


// Ex 3
string[] inventario = { "Espada", "Pocao", "Escudo", "Chave", "Mapa" };
string item;
int encontrou = 0;

Console.WriteLine("=== INVENTARIO ===");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(inventario[i]);
}

Console.WriteLine("Digite o item que deseja procurar:");
item = Console.ReadLine();

for (int i = 0; i < 5; i++)
{
    if (item == inventario[i])
    {
        encontrou = 1;
    }
}

if (encontrou == 1)
{
    Console.WriteLine("O item existe no inventario.");
}
else
{
    Console.WriteLine("O item nao existe no inventario.");
}


// Ex 4
string[] itens = { "Pocao", "Espada", "Escudo" };
int[] precos = { 20, 100, 80 };

int moedas = 150;
string escolha4;

Console.WriteLine("=== LOJA ===");
Console.WriteLine("Voce possui " + moedas + " moedas.");

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(itens[i]);
    Console.WriteLine("Preco: " + precos[i]);
}

Console.WriteLine("Escolha um item:");
escolha4 = Console.ReadLine();

if (escolha4 == "1" && moedas >= precos[0])
{
    moedas = moedas - precos[0];
    Console.WriteLine("Voce comprou uma pocao.");
}
else if (escolha4 == "2" && moedas >= precos[1])
{
    moedas = moedas - precos[1];
    Console.WriteLine("Voce comprou uma espada.");
}
else if (escolha4 == "3" && moedas >= precos[2])
{
    moedas = moedas - precos[2];
    Console.WriteLine("Voce comprou um escudo.");
}
else
{
    Console.WriteLine("Voce nao possui moedas suficientes ou escolheu uma opcao invalida.");
}

Console.WriteLine("Moedas restantes: " + moedas);

// Ex 5
int vidaJogador = 100;
int vidaInimigo = 100;
string escolha5;

while (vidaJogador > 0 && vidaInimigo > 0)
{
    Console.WriteLine("Sua vida: " + vidaJogador);
    Console.WriteLine("Vida do inimigo: " + vidaInimigo);

    Console.WriteLine("1 - Atacar");
    Console.WriteLine("2 - Curar");

    escolha5 = Console.ReadLine();

    if (escolha5 == "1")
    {
        vidaInimigo = vidaInimigo - 20;
        Console.WriteLine("Voce atacou!");
    }
    else if (escolha5 == "2")
    {
        vidaJogador = vidaJogador + 15;

        if (vidaJogador > 100)
        {
            vidaJogador = 100;
        }

        Console.WriteLine("Voce se curou!");
    }
    else
    {
        Console.WriteLine("Opcao invalida.");
    }

    if (vidaInimigo > 0)
    {
        vidaJogador = vidaJogador - 15;
        Console.WriteLine("O inimigo atacou!");
    }
}

if (vidaJogador > 0)
{
    Console.WriteLine("Voce venceu!");
}
else
{
    Console.WriteLine("Voce perdeu!");
}


// Ex 6
Random random = new Random();

string[] recompensas = { "Pocao", "50 moedas", "10 pontos", "Aumento de forca" };

int sorteio;

sorteio = random.Next(0, 4);

Console.WriteLine("=== RECOMPENSA ===");
Console.WriteLine("Voce recebeu: " + recompensas[sorteio]);

// Ex 7
Random random7 = new Random();

int vida7 = 100;
int moedas7 = 50;
int coragem = 50;
int evento;

evento = random7.Next(1, 4);

Console.WriteLine("=== EVENTO ===");

if (evento == 1)
{
    vida7 = vida7 - 20;
    Console.WriteLine("Um monstro atacou voce!");
}
else if (evento == 2)
{
    moedas7 = moedas7 + 30;
    Console.WriteLine("Voce encontrou um tesouro!");
}
else
{
    coragem = coragem + 20;
    Console.WriteLine("Voce encontrou um grupo de aventureiros!");
}

Console.WriteLine("Vida: " + vida7);
Console.WriteLine("Moedas: " + moedas7);
Console.WriteLine("Coragem: " + coragem);


// Ex 8
int reputacao = 50;
string escolha8;

Console.WriteLine("=== MISSAO ===");
Console.WriteLine("Objetivo: conseguir comida para a vila.");

Console.WriteLine("1 - Procurar comida");
Console.WriteLine("2 - Pedir ajuda");

escolha8 = Console.ReadLine();

if (escolha8 == "1")
{
    reputacao = reputacao + 20;
    Console.WriteLine("Voce encontrou comida.");
}
else if (escolha8 == "2")
{
    reputacao = reputacao + 5;
    Console.WriteLine("Voce conseguiu pouca comida.");
}
else
{
    reputacao = reputacao - 20;
    Console.WriteLine("Voce abandonou a missao.");
}

if (reputacao >= 70)
{
    Console.WriteLine("Missao concluida!");
}
else if (reputacao >= 50)
{
    Console.WriteLine("A missao teve resultado parcial.");
}
else
{
    Console.WriteLine("A missao falhou.");
}


// Ex 9
int confianca = 50;
string escolha9;

Console.WriteLine("=== DIALOGO ===");

Console.WriteLine("NPC: Voce sabe onde esta o tesouro?");
Console.WriteLine("1 - Contar a verdade");
Console.WriteLine("2 - Mentir");

escolha9 = Console.ReadLine();

if (escolha9 == "1")
{
    confianca = confianca + 20;
}
else
{
    confianca = confianca - 20;
}

Console.WriteLine("NPC: Voce vai me ajudar?");
Console.WriteLine("1 - Sim");
Console.WriteLine("2 - Nao");

escolha9 = Console.ReadLine();

if (escolha9 == "1")
{
    confianca = confianca + 20;
}
else
{
    confianca = confianca - 20;
}

if (confianca >= 70)
{
    Console.WriteLine("O NPC revelou uma pista secreta!");
}
else if (confianca >= 40)
{
    Console.WriteLine("O NPC revelou uma pequena pista.");
}
else
{
    Console.WriteLine("O NPC nao revelou nenhuma informacao.");
}

// Ex 10
string resposta;

Console.WriteLine("=== PUZZLE ===");
Console.WriteLine("Resolva o desafio para abrir a porta.");
Console.WriteLine("Quanto e 5 + 5 x 2?");

resposta = Console.ReadLine();

if (resposta == "15")
{
    Console.WriteLine("Resposta correta!");
    Console.WriteLine("A porta foi aberta!");
}
else
{
    Console.WriteLine("Resposta errada!");
    Console.WriteLine("A porta continua fechada.");
}

// Ex 11
Random random11 = new Random();

int vida11 = 100;
int moedas11 = 20;
int evento11;
string escolha11 = "";

while (escolha11 != "2")
{
    Console.WriteLine("Vida: " + vida11);
    Console.WriteLine("Moedas: " + moedas11);

    Console.WriteLine("1 - Explorar");
    Console.WriteLine("2 - Sair");

    escolha11 = Console.ReadLine();

    if (escolha11 == "1")
    {
        evento11 = random11.Next(1, 4);

        if (evento11 == 1)
        {
            moedas11 = moedas11 + 20;
            Console.WriteLine("Voce encontrou moedas!");
        }
        else if (evento11 == 2)
        {
            vida11 = vida11 - 20;
            Console.WriteLine("Voce encontrou um inimigo!");
        }
        else
        {
            Console.WriteLine("Voce nao encontrou nada.");
        }
    }
    else if (escolha11 != "2")
    {
        Console.WriteLine("Opcao invalida.");
    }
}

Console.WriteLine("Voce saiu da exploracao.");


// Ex 12
int vida12 = 100;
int vidaMaxima = 100;
string escolha12 = "";

while (escolha12 != "3")
{
    Console.WriteLine("Vida atual: " + vida12);

    Console.WriteLine("1 - Receber dano");
    Console.WriteLine("2 - Usar cura");
    Console.WriteLine("3 - Sair");

    escolha12 = Console.ReadLine();

    if (escolha12 == "1")
    {
        vida12 = vida12 - 30;

        if (vida12 < 0)
        {
            vida12 = 0;
        }
    }
    else if (escolha12 == "2")
    {
        vida12 = vida12 + 25;

        if (vida12 > vidaMaxima)
        {
            vida12 = vidaMaxima;
        }
    }
    else if (escolha12 != "3")
    {
        Console.WriteLine("Opcao invalida.");
    }

    if (vida12 == 0)
    {
        Console.WriteLine("O personagem foi derrotado!");
        escolha12 = "3";
    }
}


// Ex 13
int pontos13;

Console.WriteLine("=== RANKING ===");
Console.WriteLine("Digite sua pontuacao:");

pontos13 = int.Parse(Console.ReadLine());

if (pontos13 >= 1000)
{
    Console.WriteLine("Ranking S!");
}
else if (pontos13 >= 700)
{
    Console.WriteLine("Ranking A!");
}
else if (pontos13 >= 400)
{
    Console.WriteLine("Ranking B!");
}
else if (pontos13 >= 200)
{
    Console.WriteLine("Ranking C!");
}
else
{
    Console.WriteLine("Ranking D!");
}

// Ex 14
string[] inimigos = { "Goblin", "Esqueleto", "Orc" };

int forca14 = 50;
int vida14 = 100;
string escolha14;

Console.WriteLine("=== INIMIGOS ===");

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(inimigos[i]);
}

Console.WriteLine("Escolha um inimigo:");
escolha14 = Console.ReadLine();

if (escolha14 == "1" && forca14 >= 30)
{
    Console.WriteLine("Voce derrotou o Goblin!");
}
else if (escolha14 == "2" && forca14 >= 40)
{
    Console.WriteLine("Voce derrotou o Esqueleto!");
}
else if (escolha14 == "3" && forca14 >= 50)
{
    Console.WriteLine("Voce derrotou o Orc!");
}
else if (escolha14 == "1" || escolha14 == "2" || escolha14 == "3")
{
    vida14 = vida14 - 30;
    Console.WriteLine("Voce perdeu o confronto!");
}
else
{
    Console.WriteLine("Inimigo invalido.");
}

Console.WriteLine("Vida: " + vida14);


// Ex 15
int moedas15 = 0;
string coletadas;

Console.WriteLine("=== COLETA ===");
Console.WriteLine("Objetivo: coletar 100 moedas.");

for (int rodada = 1; rodada <= 5; rodada++)
{
    Console.WriteLine("Quantas moedas voce coletou?");
    coletadas = Console.ReadLine();

    if (coletadas == "10")
    {
        moedas15 = moedas15 + 10;
    }
    else if (coletadas == "20")
    {
        moedas15 = moedas15 + 20;
    }
    else
    {
        moedas15 = moedas15 + 5;
    }

    Console.WriteLine("Moedas coletadas: " + moedas15);
}

if (moedas15 >= 100)
{
    Console.WriteLine("Objetivo atingido!");
}
else
{
    Console.WriteLine("Objetivo nao atingido.");
}

// Ex 16
Random random16 = new Random();

int comida = 50;
int rodadas = 0;
int evento16;

while (rodadas < 5 && comida > 0)
{
    rodadas = rodadas + 1;

    evento16 = random16.Next(1, 4);

    if (evento16 == 1)
    {
        comida = comida + 20;
        Console.WriteLine("Voce encontrou comida!");
    }
    else if (evento16 == 2)
    {
        comida = comida - 20;
        Console.WriteLine("Voce perdeu comida!");
    }
    else
    {
        comida = comida - 10;
        Console.WriteLine("Voce gastou comida!");
    }

    Console.WriteLine("Comida: " + comida);
}

if (comida > 0 && rodadas == 5)
{
    Console.WriteLine("Voce sobreviveu!");
}
else
{
    Console.WriteLine("Voce nao sobreviveu.");
}


// Ex 17
int coragem17 = 60;
string escolha17;

Console.WriteLine("=== ESCOLHA DE CAMINHO ===");

Console.WriteLine("1 - Floresta");
Console.WriteLine("2 - Montanha");
Console.WriteLine("3 - Caminho escuro");

escolha17 = Console.ReadLine();

if (escolha17 == "1")
{
    Console.WriteLine("Voce encontrou um caminho seguro.");
}
else if (escolha17 == "2" && coragem17 >= 50)
{
    Console.WriteLine("Voce conseguiu atravessar a montanha!");
}
else if (escolha17 == "3" && coragem17 >= 80)
{
    Console.WriteLine("Voce atravessou o caminho escuro!");
}
else if (escolha17 == "2" || escolha17 == "3")
{
    Console.WriteLine("Voce nao possui coragem suficiente.");
}
else
{
    Console.WriteLine("Caminho invalido.");
}


// Ex 18
Random random18 = new Random();

int moedas18 = 50;
int sorteio18;

sorteio18 = random18.Next(1, 4);

Console.WriteLine("=== BAU ===");

switch (sorteio18)
{
    case 1:
        moedas18 = moedas18 + 50;
        Console.WriteLine("Voce encontrou 50 moedas!");
        break;

    case 2:
        Console.WriteLine("Voce encontrou uma espada!");
        break;

    case 3:
        Console.WriteLine("Voce encontrou uma pocao!");
        break;
}

Console.WriteLine("Moedas atuais: " + moedas18);


// Ex 19
string[] nomes19 = { "Arthur", "Luna", "Carlos" };
int[] vidas = { 100, 80, 120 };
int[] forcas = { 70, 90, 60 };

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Nome: " + nomes19[i]);
    Console.WriteLine("Vida: " + vidas[i]);
    Console.WriteLine("Forca: " + forcas[i]);
}

if (forcas[0] > forcas[1] && forcas[0] > forcas[2])
{
    Console.WriteLine("Arthur possui a maior forca.");
}
else if (forcas[1] > forcas[0] && forcas[1] > forcas[2])
{
    Console.WriteLine("Luna possui a maior forca.");
}
else
{
    Console.WriteLine("Carlos possui a maior forca.");
}