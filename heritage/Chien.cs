namespace heritage;

public class Chien : Animal
{
    public string Race { get; set; }

    public Chien(string nom, int age, string race) : base(nom, age)
    {
        Race = race;
    }

    public override void Manger()
    {
        Console.WriteLine($"{Nom} le chien mange ses croquettes.");
    }

    public void Aboyer()
    {
        Console.WriteLine($"{Nom} aboie : Woof!");
    }
}