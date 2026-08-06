// See https://aka.ms/new-console-template for more information

// Exercício 1
Console.WriteLine("Escreva seu nome:");
string nome  = Console.ReadLine();
Console.WriteLine("Seja bem vindo(a)," + nome);

// Exercício 2
int vida = 100;
Console.WriteLine("Sua vida atual: " + vida);
int vida2 = 80;
Console.WriteLine("Sua vida atual: " + vida2);

// Exercício 3
Console.WriteLine("Escreva sua pontuação inicial:");
int pontuacao = int.Parse(Console.ReadLine());
if (pontuacao > 0)
{
    Console.WriteLine("Você já começou pontuando!");
}
else
{
    Console.WriteLine("Você ainda não tem pontos.");
}

// Exercício 4
Console.WriteLine("Escreva sua vida atual:");
int vida3 = int.Parse(Console.ReadLine());
if (pontuacao > 0)
{
    Console.WriteLine("O jogador ainda está vivo.");
}
else
{
    Console.WriteLine("Game Over.");
}

// Exercício 5
Console.WriteLine("Escreva sua energia:");
int energia = int.Parse(Console.ReadLine());
if (pontuacao >= 10)
{
    Console.WriteLine("Você pode atacar!");
}
else
{
    Console.WriteLine("Energia insuficiente.");
}

// Exercício 6
Console.WriteLine("Escolha uma das classes: Guerreiro, mago ou arqueiro");
Console.WriteLine("Escreva a classe escolhida:");
string classe = (Console.ReadLine());
if (classe == "Guerreiro")

{
    Console.WriteLine("Você escolheu Guerreiro.");
}
else
{
    Console.WriteLine("Classe diferente de Guerreiro.");
}

// Exercício 7
Console.WriteLine("Você tem a chave: true or false?");
string temChave = Console.ReadLine();
if (temChave == "true")
{
    Console.WriteLine("A porta abriu.");
}
else
{
    Console.WriteLine("A porta está trancada.");
}