Console.WriteLine($"Digite uma nota entre 0 e 10");
float nota = float.Parse(Console.ReadLine());

while (nota < 0f)
{
    Console.WriteLine($"Digite o sua nota novamente, pois o valor é inválido: ");
    nota = float.Parse(Console.ReadLine());
}

while (nota > 10f)
{
    Console.WriteLine($"Digite o sua nota novamente, pois o valor é inválido: ");
    nota = float.Parse(Console.ReadLine());
}
Console.WriteLine($"O valor {nota} válido");