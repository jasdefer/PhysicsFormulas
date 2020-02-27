using BenchmarkDotNet.Attributes;
using PhysicsFormulas.Mechanics;

namespace PhysicsFormulasBenchmark.MechanicsBenchmarks
{
    public class AccelerationBenchmarks
    {
        public const double T = 10;
        public const double V = 3;
        public const double S = 10;

        [Benchmark]
        public double UniformAcceleration()
        {
            var s = Acceleration.UniformAcceleration(S, T, V);
            return s;
        }
    }
}