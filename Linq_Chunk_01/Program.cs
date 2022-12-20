Console.WriteLine("Utilizando o método Chunk da LINQ\n");

int[] numeros = Enumerable.Range(1, 50).ToArray();

foreach (var numero in numeros)
  Console.Write($"{numero} ");

Console.WriteLine("\n\nInforme o número de elementos por fatia: ");
var elementosPorFatia = int.Parse(Console.ReadLine());

var fatias = numeros.Chunk(elementosPorFatia);

Console.WriteLine($"numeros.Chunk({elementosPorFatia})\n");
var numeroFatias = fatias.Count();
Console.WriteLine($"Número de fatias: {numeroFatias}\n");
Console.WriteLine("Percorrendo cada fatia: \n");

for (int i = 0; i < numeroFatias; i++)
{
  Console.Write($"Fatia {i}: ");
  Resultado(fatias.ElementAt(i));
}

Console.ReadKey();

void Resultado(IEnumerable<int> numeros)
{
  foreach (var numero in numeros)
    Console.Write($"{numero} ");
  Console.WriteLine();
}