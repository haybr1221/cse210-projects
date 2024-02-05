public abstract class Animal {
    // We can extend from abstract classes to specific classes
        // is not required in C#

    protected string name;
    protected string sound;

    protected Animal(string name, string sound) {
        // only a class that is a child of the parent can call this method
        this.name = name;
        this.sound = sound;
    }

    public virtual void MakeSound() {
        Console.WriteLine("**Ominous Silence**");
    }
}