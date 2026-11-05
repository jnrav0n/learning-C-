using System;

class Animal 
{
    public string Name { get; set; }
    public string Noise { get; set; }
    public string Food { get; set; }

    public Animal(string name, string noise, string food) 
    {
        Name = name;
        Noise = noise;
        Food = food;
    }

    public string Speak() 
    {
        return Noise;
    }

    public string Eats() 
    {
        return Name + " is eating " + Food;
    }
}

class Program 
{
    static void Main(string[] args) 
    {
        Animal dog = new Animal("Timmy", "Bark", "Bacon");
        Console.WriteLine(dog.Eats());
    }
}