using Heranca;

string nome;
string especie;

string eVenenoso;
bool venenoso;

/* Console.WriteLine("Informe o nome do mamífero:");
nome = Console.ReadLine();

Console.WriteLine("Informe a espécie do mamífero:");
especie = Console.ReadLine();

Mamifero mamifero = new Mamifero(nome, especie);

mamifero.Mamar(); */


Console.WriteLine("Informe o nome do réptil:");
nome = Console.ReadLine();

Console.WriteLine("Informe a espécie do réptil:");
especie = Console.ReadLine();

Console.WriteLine("Informe se o réptil é venenoso (S/N):");
eVenenoso = Console.ReadLine();

if (eVenenoso.ToLower() == "s" || eVenenoso.ToLower() == "sim")
{
    venenoso = true;
} else
{
    venenoso = false;
}

Reptil reptil = new Reptil(nome, especie, venenoso);

reptil.BotarOvo();