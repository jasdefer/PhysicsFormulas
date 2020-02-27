using BenchmarkDotNet.Attributes;
using PhysicsFormulas.Mechanics;
using System;

namespace PhysicsFormulasBenchmark.MechanicsBenchmarks
{
    public class ForceBenchmarks
    {
        public const double A = 3;
        public const double G = 9.81;
        public const double ALPHA = Math.PI/4;
        public const double M1 = 1500;
        public const double M2 = 3000;
        public const double C = 0.03;
        public const double E = 1.12;
        public const double CW = 2;
        public const double V = 30;
        public const double P = 1.2;
        public const double AREA = 3;

        [Benchmark]
        public double RollingResistance()
        {
            var f = Force.RollingResistance(M1 + M2, ALPHA, C, G);
            return f;
        }

        [Benchmark]
        public double AccelerationForce()
        {
            var f = Force.AccelerationForce(M1, M2, A, E);
            return f;
        }

        [Benchmark]
        public double AirResistance()
        {
            var f = Force.AirResistance(CW, AREA, V, P);
            return f;
        }

        [Benchmark]
        public double DownHillForce()
        {
            var f = Force.DownHillForce(M1 + M2, ALPHA, G);
            return f;
        }
    }
}