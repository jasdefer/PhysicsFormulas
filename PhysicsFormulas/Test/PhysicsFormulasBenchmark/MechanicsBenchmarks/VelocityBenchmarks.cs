using BenchmarkDotNet.Attributes;
using PhysicsFormulas.Mechanics;

namespace PhysicsFormulasBenchmark.MechanicsBenchmarks
{
    public class VelocityBenchmarks
    {
        public const double T = 10;
        public const double A = 1;
        public const double S = 10;

        [Benchmark]
        public double UniformAcceleration()
        {
            var s = Velocity.UniformAcceleration(S, T, A);
            return s;
        }

        [Benchmark]
        public double SteadyMotion()
        {
            var s = Velocity.SteadyMotion(S, T);
            return s;
        }
    }
}
