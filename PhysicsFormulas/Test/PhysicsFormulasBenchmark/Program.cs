using BenchmarkDotNet.Running;
using PhysicsFormulas.Mechanics;
using PhysicsFormulasBenchmark.MechanicsBenchmarks;
using System;
using System.IO;
using System.Text;

namespace PhysicsFormulasBenchmark
{
    public class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<DisplacementBenchmarks>();
            BenchmarkRunner.Run<VelocityBenchmarks>();
            BenchmarkRunner.Run<AccelerationBenchmarks>();
        }
    }
}