List<int> Lépesszamlalo = new List<int>();

double osszeg = 0;

for (int i = 0; i < 5; i++)

{
    osszeg += Lépesszamlalo[i];
}

double atlag = osszeg/Lépesszamlalo.Count;

if(atlag < 10000)
    {
        Console.WriteLine("Az átlagos lépésszám kevesebb, mint 1000.");
    }
    else if (atlag >= 1000 && atlag <= 5000)
    {
        Console.WriteLine("Az átlagos lépésszám 1000 és 5000 között van.");
    }
    else
    {
        Console.WriteLine("Az átlagos lépésszám több, mint 5000.");
    }