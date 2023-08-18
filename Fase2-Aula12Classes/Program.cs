
using Fase2_Aula12Classes;

Console.WriteLine("Hello, World!");
Personagem guerreiro= new Personagem();
guerreiro.nome = "Camilaa";
guerreiro.raca = "Humanoo";
guerreiro.poder = 1000;
guerreiro.mostra();

Personagem mago= new Personagem();
mago.raca = "Elfo";
mago.poder = 100;
mago.nome = "Harry";

mago.mostra();


Personagem bruxo = mago;
bruxo.nome = "Hermione";
bruxo.mostra();

Personagem atiradora= new Personagem();

atiradora.raca = "Imperatriz";
atiradora.poder = 300;
atiradora.nome = "Reyna";

atiradora.mostra();



Console.ReadKey();
