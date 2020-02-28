using BenchmarkDotNet.Attributes;
using PhysicsFormulas.Mechanics;

namespace PhysicsFormulasBenchmark.MechanicsBenchmarks
{
    public class DurationBenchmarks
    {
        public const double S = 10;
        public const double A = 1;
        public const double V = 3;

        [Benchmark]
        public double UniformAcceleration()
        {
            var t = Duration.UniformAcceleration(V, S, A);
            return t.t1;
        }

        [Benchmark]
        public double SteadyMovement()
        {
            var t = Duration.SteadyMovement(V, S);
            return t;
        }
    }
}