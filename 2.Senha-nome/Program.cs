Console.WriteLine($"Diga o seu nome: ");
string nome = Console.ReadLine().ToLower();
string senha;

do 
{
    Console.WriteLine($"Diga a sua senha: ");
    senha = Console.ReadLine().ToLower();
}while(nome == senha);