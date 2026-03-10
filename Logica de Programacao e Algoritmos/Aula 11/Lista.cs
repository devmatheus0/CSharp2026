using static System.Console;
using static System.Linq.Enumerable;

List <string> nomes = new List<string>();
nomes.Add ("João");
nomes.Add ("Maria");
nomes.Add ("Clodoaldo");
nomes.Add("Maria");
WriteLine(nomes);
foreach (var item in Range (0, nomes.Count)) //Count retorna o tamanho da lista
{
    WriteLine(nomes [item]);
}
WriteLine("--------------");
nomes.Remove("Maria");
foreach (var item in Range (0, nomes.Count)) //Count retorna o tamanho da lista
{
    WriteLine(nomes [item]);
}

WriteLine("--------------");
WriteLine("Indice que contém 'João': " + nomes.Contains("João"));

nomes.Clear();
foreach (var item in Range (0, nomes.Count)) //Count retorna o tamanho da lista
{
    WriteLine(nomes [item]);
}
