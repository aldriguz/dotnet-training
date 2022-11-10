using BenchmarkDotNet.Running;

// Need to run it in Release
var summary = BenchmarkRunner.Run(typeof(Program).Assembly);

