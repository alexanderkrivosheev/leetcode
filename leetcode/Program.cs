// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;

Console.WriteLine("Hello, World!");
BenchmarkRunner.Run<leetcode._125_valid_palindrome.Benchmark>();
Console.WriteLine("Done!");