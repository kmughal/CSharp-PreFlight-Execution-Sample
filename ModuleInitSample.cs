public class ModuleInitSample
{

    static ModuleInitSample() => Console.WriteLine("ModuleInitSample => constructor");

    [System.Runtime.CompilerServices.ModuleInitializer]
    public static void Init() => Console.WriteLine("ModuleInitializer => Init being called.");

    [System.Runtime.CompilerServices.ModuleInitializer]
    public static void Init1() => Console.WriteLine("ModuleInitializer => Init1 being called.");
}


/* When runtime loads the dll it executes piece of code first which is 
decorated with ModuleInitializer attribute before running anything else 
*/