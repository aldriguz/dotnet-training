// See https://aka.ms/new-console-template for more information
Console.WriteLine("---------------------------");
Console.WriteLine("Explicit implementation: Tesla Model S");

//using explicit implementation
ICar tesla = new TeslaModelS();
tesla.StartEngine();
tesla.StopEngine();

var teslaInvalid = new TeslaModelS();
// compiler error due to Explicit implementation
//teslaInvalid.StartEngine();

Console.WriteLine("---------------------------");
Console.WriteLine("Standard implementation using var: Toyota Corolla 2021");
//now not using explicit implementation
var toyota2021 = new ToyotaCorolla();
toyota2021.StartEngine();
toyota2021.StopEngine();


Console.WriteLine("---------------------------");
Console.WriteLine("Standard implementation using ICar (same result): Toyota Corolla 2021");
ICar toyotaExplcit = new ToyotaCorolla();
toyotaExplcit.StartEngine();
toyotaExplcit.StopEngine();
