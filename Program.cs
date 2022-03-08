
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
Console.WriteLine("Static Constructor Example");
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
var instance = new StaticConstructorClass();

Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
Console.WriteLine("[System.Runtime.CompilerServices.ModuleInitializer] Example");
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
var instanceOfModuleInitSample = new ModuleInitSample();


// Another option is to set an environment variable with dll name which you want to execute first  DOTNET_STARTUP_HOOKS=myapp.dll