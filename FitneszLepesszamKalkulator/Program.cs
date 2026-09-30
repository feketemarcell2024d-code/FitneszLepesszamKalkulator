List<int> Lépesszamlalo = new List<int>();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"[{i + 1}] nap lépésszám: ");
    int lépésszám = int.Parse(Console.ReadLine());
    Lépesszamlalo.Add(lépésszám);
}