﻿using BenchmarkDotNet.Running;
using PhysicsFormulasBenchmark.MechanicsBenchmarks;

namespace PhysicsFormulasBenchmark
{
    public class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<DisplacementBenchmarks>();
        }
    }
}