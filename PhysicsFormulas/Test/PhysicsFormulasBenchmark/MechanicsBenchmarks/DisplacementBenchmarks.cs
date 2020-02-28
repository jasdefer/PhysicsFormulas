﻿using BenchmarkDotNet.Attributes;
using PhysicsFormulas.Mechanics;

namespace PhysicsFormulasBenchmark.MechanicsBenchmarks
{
    public class DisplacementBenchmarks
    {
        public double T = 10;
        public const double A = 1;
        public const double V0 = 1;

        [Benchmark]
        public double UniformAcceleration()
        {
            var s = Displacement.UniformAcceleration(V0, T, A);
            return s;
        }

        [Benchmark]
        public double SteadyMotion()
        {
            var s = Displacement.SteadyMotion(V0, T);
            return s;
        }
    }
}