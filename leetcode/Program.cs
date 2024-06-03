// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;

Console.WriteLine("Hello, World!");
BenchmarkRunner.Run<leetcode.trees._serialize_and_deserialize.Benchmark>();
Console.WriteLine("Done!");