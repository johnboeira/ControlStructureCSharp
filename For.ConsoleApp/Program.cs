string[] nomes = ["Adriano", "Julia", "Lucas", "Jonas"];

for (int index = 0; index < nomes.Length; index++)
{
    Console.WriteLine(nomes[index]);
}

List<string> nomes2 = ["Luis", "Ana"];

nomes2.Add("Novo nome");
nomes2.Add("mais um nome");

for (int index = 0; index < nomes2.Count; index++)
{
    Console.WriteLine(nomes2[index]);
}