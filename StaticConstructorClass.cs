public class StaticConstructorClass
{
    public StaticConstructorClass() => Console.WriteLine("I am a constructor");
    static StaticConstructorClass() => Console.WriteLine("I am a static constructor!");
}

//synopsis: Execute something before Main thread execution
// option1: use static constructor!