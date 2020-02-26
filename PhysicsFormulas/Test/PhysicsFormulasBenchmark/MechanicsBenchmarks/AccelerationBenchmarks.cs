using BenchmarkDotNet.Attributes;
using PhysicsFormulas.Mechanics;

namespace PhysicsFormulasBenchmark.MechanicsBenchmarks
{
    public class AccelerationBenchmarks
    {
        [Params(10, -10)]
        public double T { get; set; }
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