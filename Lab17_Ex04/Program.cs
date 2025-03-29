Animal[] animals = new Animal[3];
animals[0] = new Dog();
animals[1] = new Bird();
animals[2] = new Fish();

foreach (var animal in animals)
{
    animal.Move();
    animal.Speak(); // เรียกใช้เมธอด Speak()
}

interface IMovable
{
    void Move();
}

interface ISpeakable
{
    void Speak();
}

abstract class Animal : IMovable, ISpeakable
{
    public abstract void Move();
    public abstract void Speak(); // กำหนดให้คลาสที่สืบทอดต้อง implement เมธอดนี้
}

class Dog : Animal
{
    public override void Move()
    {
        System.Console.WriteLine("Dog move by running on the ground");
    }

    public override void Speak()
    {
        System.Console.WriteLine("Dog barks");
    }
}

class Fish : Animal
{
    public override void Move()
    {
        System.Console.WriteLine("Fish move by swimming in the water");
    }

    public override void Speak()
    {
        System.Console.WriteLine("Fish can't speak");
    }
}

class Bird : Animal
{
    public override void Move()
    {
        System.Console.WriteLine("Bird move by flying in the air");
    }

    public override void Speak()
    {
        System.Console.WriteLine("Bird chirps");
    }
}
