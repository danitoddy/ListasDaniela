// See https://aka.ms/new-console-template for more information

// Exercício 1
descricaojogo();
nomejogador();
string nome1 = Console.ReadLine();
frase();

//Atividade 2
Console.WriteLine("Conheça seus 3 companheiros de missão:");
dialogo("Daphne", "Uma garota extrovertida, otimista e aventureira. Adora conhecer pessoas novas e acredita que toda amizade começa com uma boa conversa.", "Espero que a gente se dê bem. Quem sabe essa aventura não nos aproxima ainda mais?");
dialogo("Simon", "Um rapaz calmo, inteligente e reservado. Prefere observar antes de agir e valoriza conversas sinceras.", "Se precisar de alguém para conversar ou pensar em uma solução, pode contar comigo.");
dialogo("Benedict", "Um jovem carismático, brincalhão e cheio de energia. Está sempre disposto a animar o grupo com seu bom humor.", "Vamos aproveitar essa jornada juntos. Tenho certeza de que ainda vamos viver momentos inesquecíveis!");

//Atividade 3
criarstatus();


// voids
void descricaojogo()
{
    Console.WriteLine("FreeRomance");
    Console.WriteLine("Este é um jogo de relacionamento, onde o objetivo é achar seu par romântico presencialmente");
    Console.WriteLine("Seu objetivo é que os players possam desenvolver relacionamentos, românticos ou não, conhecendo pessoas novas");
}

void nomejogador()
{
    Console.WriteLine("Qual seu nome?");
}

void frase()
{
    Console.WriteLine("Olá, seja bem-vindo(a) ao FreeRomance, preparamos uma experiência incrível para você.");
}

void dialogo(string nome, string descricaoperson, string mensagem)
{
    Console.WriteLine(nome + ": " + descricaoperson + ": " + mensagem);
}

void criarstatus()
{
    Console.WriteLine("Vamos criar seu status");
    Console.WriteLine("Qual seu nome?");
    string nome2 = Console.ReadLine();
    Console.WriteLine("Qual sua classe?");
    string classe = Console.ReadLine();
    Console.WriteLine("Qual sua vida?");
    int vida = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Qual sua energia?");
    int energia = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Qual sua força?");
    int forca = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Quantas moedas você tem?");
    int moedas = Convert.ToInt32(Console.ReadLine());
    mostrarstatus(nome2, classe, vida, energia, forca, moedas);
}

void mostrarstatus(string nome, string classe, int vida, int energia, int forca, int moedas)
{
    Console.WriteLine("Nome: " + nome + " Classe: " + classe + " Vida: " + vida + " Energia: " + forca + " Moedas: " + moedas);
}

