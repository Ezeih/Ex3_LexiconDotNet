// See https://aka.ms/new-console-template for more information
using Ex3_LexiconDotNet;

internal class Wolfman : Animal
{
    public Wolfman(string name, double weight, int age) : base(name, weight, age)
    {
    }

    public override void DoSound()
    {
        Console.WriteLine("Wolfman says: Howl!");
    }
}