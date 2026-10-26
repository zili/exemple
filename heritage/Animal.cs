namespace heritage;

public class Animal
{
    public string Nom { get; set; }
    public int Age { get; set; }

    public Animal(string nom, int age)
    {
        Nom = nom;
        Age = age;
    }

    public virtual void Manger()
    {
        Console.WriteLine($"{Nom} mange.");
    }

    public virtual void Dormir()
    {
        Console.WriteLine($"{Nom} dort.");
    }
}
