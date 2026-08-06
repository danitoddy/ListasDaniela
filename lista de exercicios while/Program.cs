// See https://aka.ms/new-console-template for more information

// Exercicio 1
int passos = 0;

while (passos <= 10)
{
    Thread.Sleep(1000);
    Console.WriteLine("O personagem deu mais um passo. Passos atuais: "
        + passos);
    passos = passos + 1;
}
Console.WriteLine("Você chegou ao destino.");


// Exercicio 2
Console.WriteLine("Rolando o dado... ");
Random sorteio = new Random();
int dado = sorteio.Next(1, 7);
if (dado == 6)
{
    Console.WriteLine("Você tirou 6! Fim da rolagem.");
}
else
{
    Console.WriteLine("Sorteie de novo");
}


// Exercicio 3
Random sorteio1 = new Random();
int porta = sorteio1.Next(1, 6);
if (porta == 5)
{
    Console.WriteLine("A porta se abriu!");
}
else
{
    Console.WriteLine("A porta continua fechada...");
}


// Exercicio 4
Console.WriteLine("Procurando o item raro...");
Random sorteio2 = new Random();
int item = sorteio2.Next(1, 11);
int tentativas = 0;
while (item != 10)
{
    if (item == 10)
    {
        Console.WriteLine("Você encontrou o item raro");
    }
    else
    {
        Console.WriteLine("Você não encontrou o item raro, tente novamente.");
    }
    tentativas = tentativas + 1;
    item = sorteio2.Next(1, 11);
}
Console.WriteLine("Você encontrou o item raro.");
Console.WriteLine(tentativas + 1);


// Exercicio 5
Random sorteio3 = new Random();
int senha = sorteio3.Next(1, 21);
int tentativas = 0;
Console.WriteLine("Qual é a senha? Escolha um número de 1 a 20.");
int palpite = int.Parse(Console.ReadLine());
while (palpite != senha)
{
    if (palpite == senha)
    {
        Console.WriteLine("Você acertou!");
    }
    else if (palpite >= senha)
    {
        Console.WriteLine("O número secreto é maior.");
    }
    else if (palpite <= senha)
    {
        Console.WriteLine("O número secreto é menor.");
    }
    senha = sorteio3.Next(1, 21);
}
Console.WriteLine("Você acertou");


// Atividade 5 - Adivinhe o número

Random sorteio5 = new Random();
int numero = sorteio5.Next(1, 21);
int tentativas2 = 0;
Console.WriteLine("Adivinhe o número entre 1 e 20");
int palpite1 = int.Parse(Console.ReadLine());

while (palpite1 != numero)
{
    if (palpite1 == numero)
    {
        Console.WriteLine("Você acertou!");
    }

    else if (palpite1 <= numero)
    {
        Console.WriteLine("O número secreto é maior.");
    }
    else if (palpite1 >= numero)
    {
        Console.WriteLine("O número secreto é menor.");
    }
    numero = sorteio5.Next(1, 21);
}
Console.WriteLine("Você acertou!");


// Atividade 6
Random sorteio6 = new Random();
int opcao = sorteio6.Next(1, 4);
int cristal = 0;
while (cristal <= 4)
{
    opcao = sorteio5.Next(1, 4);
    Console.WriteLine("1 ");
    Console.WriteLine("2 ");
    Console.WriteLine("3 ");

    if (opcao == 1)
    {
        cristal = cristal + 1;
        Console.WriteLine("Encontrou um Cristal. " + cristal);
    }
    else if (opcao == 2) { Console.WriteLine("Não encontrou nada."); }
    else if (opcao == 3)
    {
        cristal = cristal - 1;
        Console.WriteLine("Perdeu um Cristal.");
    }
    else { Console.WriteLine("Opção inválida."); }
}


// Exercício 7
int energia = 100;
Random sorteio7 = new Random();
int gasto = sorteio7.Next(5, 21);
int vidafinal = energia - gasto;
while (energia > 0)
{
    if (vidafinal <= 0)
    {
        Console.WriteLine("A lanterna apagou."); break;
    }
    else
    {
        Console.WriteLine("Você gastou: " + gasto + " de energia. Energia atual: " + vidafinal);
        energia = vidafinal;
        gasto = sorteio7.Next(5, 21);
        vidafinal = energia - gasto;
    }
}


// Exercício 8
int menu = 0;
Random random8 = new Random();
int menu2 = random8.Next(1, 4);
while (menu != 2)
{
    Console.WriteLine("1 - Explorar");
    Console.WriteLine("2 - Sair");
    menu = int.Parse(Console.ReadLine());

    if (menu == 1)
    {
        if (menu2 == 1)
        {
            Console.WriteLine("Você encontrou moedas.");
        }
        else if (menu2 == 2)
        {
            Console.WriteLine("Você encontrou uma pista");
        }
        else if(menu2 == 3)
        {
            Console.WriteLine("Você encontrou um obstáculo.");
        }
        else
        {
            Console.WriteLine("Nada aconteceu.");
        }
    }
    else if (menu == 2) { Console.WriteLine("Você saiu."); }
    else { Console.WriteLine("Opção inválida."); }
}


// exercício 9
int pontos = 0;
Random sorteio8 = new Random();
int total = sorteio8.Next(5, 16);
int pontofinal = pontos + total;
while (pontos < 50)
{
    if (pontofinal >= 50)
    {
        Console.WriteLine("Objetivo concluído."); break;
    }
    else
    {
        Console.WriteLine("Você ganhou: " + total + " de pontos. Pontuação atual: " + pontofinal);
        pontos = pontofinal;
        total = sorteio8.Next(5, 16);
        pontofinal = pontos + total;
    }
}


// Exercício 10
int vida = 100; 
int rodadas = 0;
Random random9 = new Random();
int evento = random9.Next(1, 5);
Console.WriteLine("Seja bem-vindo! O dado sorteará um evento para você!");
while (vida > 0 && rodadas < 10)
{
    Console.WriteLine("1 - Encontrou suprimentos: ganha 10 de vida");
    Console.WriteLine("2 - Caiu em armadilha: perde 20 de vida");
    Console.WriteLine("3 - Descansou: ganha 5 de vida");
    Console.WriteLine("4 - Enfrentou perigo: perde um valor aleatório entre 5 e 25");

    if (vida <= 0 && rodadas >= 18)
    {
        Console.WriteLine("Você não sobreviveu."); break;

        evento = random9.Next(1, 5);
        Console.WriteLine(1);
        Console.WriteLine(2);
        Console.WriteLine(3);
        Console.WriteLine(4);

        if (evento == 1)
        {
            vida = +10;
            Console.WriteLine("Encontrou suprimentos: ganha 10 de vida");
        }
        else if (evento == 2)
        {
            vida = -20;
            Console.WriteLine("Caiu em armadilha: perde 20 de vida");
        }
        else if (vida == 3)
        {
            vida = +5;
            Console.WriteLine("Descansou: ganha 5 de vida");
        }
        else if (vida == 4)
        {
            int perda = random9.Next(1, 5);
            Console.WriteLine("Enfrentou perigo: perde um valor aleatório entre 5 e 25");
        }
    }
    else 
    { 
        Console.WriteLine("Você sobriviveu aos eventos."); 
    }
    rodadas++;
    Console.WriteLine("Rodada " + rodadas);
    Console.WriteLine("Vida atual: " + vida);
    int dano = random9.Next(1, 11);
    vida -= dano;
    Console.WriteLine("Você recebeu de dano: " + dano );
}
