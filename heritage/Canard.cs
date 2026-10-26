namespace heritage;

public class Canard : Animal, IVolant, INageant
{
    public int AltitudeMax { get; private set; }
    public int ProfondeurMax { get; private set; }

    public Canard(string nom, int age) : base(nom, age)
    {
        AltitudeMax = 1000;
        ProfondeurMax = 10;
    }

    public void Voler()
    {
        Console.WriteLine($"{Nom} vole dans le ciel.");
    }

    public void Nager()
    {
        Console.WriteLine($"{Nom} nage dans l'eau.");
    }

    public override void Manger()
    {
        Console.WriteLine($"{Nom} mange du pain au bord de l'eau.");
    }
}
