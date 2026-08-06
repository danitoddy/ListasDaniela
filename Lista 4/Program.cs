// See https://aka.ms/new-console-template for more information

// Ex 1
string[] personagens = { "Luna", "Kai", "Mika" };
for (int i = 0; i < personagens.Length; i++)

{
    Thread.Sleep(1000);
    Console.WriteLine(personagens[i]);

}


// Ex 2
string[] itens = { "Poção", "Espada", "Escudo", "Mapa" };
Console.WriteLine(itens[0]); // Poção
Console.WriteLine(itens[1]); // Espada
Console.WriteLine(itens[2]); // Escudo
Console.WriteLine(itens[3]); // Mapa

// Ex 3
string[] inventario = { "Inventário:", "Chave", "Mapa", "Espada", "Cristal" };
for (int i = 0; i < inventario.Length; i++)

{
    Thread.Sleep(1000);
    Console.WriteLine(inventario[i]);

}

// Ex 4

string[] fases = { "Floresta", "Cavernas", "Casrelo", "Laboratório" };

for (int i = 0; i < fases.Length; i++)

{

    Console.WriteLine((i + 1 + "  " + fases[i]));

}

// Ex 5

int[] pontos = { 100, 250, 300, 150, 400 };

for (int i = 0; i < pontos.Length; i++)

{

    Console.WriteLine("Fase" + (i + 1) + ": " + pontos[i]);

}

// Ex 6

int[] pontos6 = { 100, 250, 300, 150, 400, };

int total = 0;

for (int i = 0; i < pontos6.Length; i++)

{

    total += pontos6[i];

}

//Ex 7

Console.WriteLine("Pontuação total:" + total);

int[] partidas = { 80, 120, 60, 150, };

int maior = partidas[0];

for (int i = 1; i < partidas.Length; i++)

{

    if (partidas[i] > maior)

        maior = partidas[i];

}

// Ex 8

Console.WriteLine("Maior pontuação:" + maior);

string[] inventario8 = { "Poção", "Mapa", "Chave", "Cristal" };

bool encontrou = false;

Console.WriteLine("Digite o item que deseja procurar:");

string busca = Console.ReadLine();

for (int i = 0; i < inventario8.Length; i++)

{

    if (inventario8[i] == busca)

        encontrou = true;

}

if (encontrou)

    Console.WriteLine("Item encontrado!");

else

    Console.WriteLine("Item não encontrado.");

// Ex 9
string[] inimigos = { "Slime", "Morcego", "Goblin", "Esqueleto" };

Console.WriteLine(" Inimigos encontrados:");

Console.WriteLine();

for (int i = 0; i < inimigos.Length; i++)

{

    Console.WriteLine("Um " + inimigos[i] + " apareceu!");

}

Console.WriteLine();

Console.WriteLine("Total de inimigos: " + inimigos.Length);

// Ex 10
string[] nome = { "Luna", "Kai", "Mika" };

int[] vidas = { 100, 80, 50 };

for (int i = 0; i < nome.Length; i++)

{

    if (vidas[i] > 70)

        Console.WriteLine(nome[i] + " - " + vidas[i] + " - saudável");

    else

        Console.WriteLine(nome[i] + " - vida: " + vidas[i] + " - Ferido");

}




