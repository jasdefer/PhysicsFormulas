using PhysicsFormulas.Mechanics.Force;

namespace PhysicsFormulasUnitTests.Mechanics;

[TestClass]
public class ForceTests
{
    [TestMethod]
    public void AccelerationForceTest()
    {
        var f = 91;
        var e = 2;
        var massVehicle = 5;
        var massLoad = 3;
        var a = 7;

        Assert.AreEqual(f, AccelerationForce.GetForce(e, massVehicle, massLoad, a));
        Assert.AreEqual(e, AccelerationForce.GetMassFactor(f, massVehicle, massLoad, a));
        Assert.AreEqual(massVehicle, AccelerationForce.GetVehicleMass(f, e, massLoad, a));
        Assert.AreEqual(massLoad, AccelerationForce.GetVehicleLoad(f, e, massVehicle, a));
        Assert.AreEqual(a, AccelerationForce.GetAcceleration(f, e, massVehicle, massLoad));
    }

    [TestMethod]
    public void AirResistanceTest()
    {
        var f = 3185;
        var cw = 2;
        var area = 5;
        var airDensity = 13;
        var relativeVelocity = 7;

        Assert.AreEqual(f, AirResistance.GetForce(cw, area, airDensity, relativeVelocity));
        Assert.AreEqual(cw, AirResistance.GetDragCoefficient(f, area, airDensity, relativeVelocity));
        Assert.AreEqual(area, AirResistance.GetArea(f, cw, airDensity, relativeVelocity));
        Assert.AreEqual(airDensity, AirResistance.GetAirDensity(f, cw, area, relativeVelocity));
        Assert.AreEqual(relativeVelocity, AirResistance.GetRelativeVelocity(f, cw, area, airDensity));
    }

    [TestMethod]
    public void DownHillForceTest()
    {
        var f = 5;
        var fg = 10;
        var alpha = Math.PI / 6;
        Assert.AreEqual(f, DownhillForce.GetDownhillForce(fg, alpha), 1e-14);
        Assert.AreEqual(fg, DownhillForce.GetWeightForce(f, alpha), 1e-14);
        Assert.AreEqual(alpha, DownhillForce.GetAlpha(f, fg), 1e-14);
    }

    [TestMethod]
    public void NormalForceTest()
    {
        var fn = 5;
        var fg = 10;
        var alpha = Math.PI / 3;
        Assert.AreEqual(fn, NormalForce.GetNormalForce(fg, alpha), 1e-14);
        Assert.AreEqual(fg, NormalForce.GetWeightForce(fn, alpha), 1e-14);
        Assert.AreEqual(alpha, NormalForce.GetAlpha(fn, fg), 1e-14);
    }

    [TestMethod]
    public void RollingResistanceTest()
    {
        var fr = 6;
        var fn = 2;
        var c = 3;
        Assert.AreEqual(fn, RollingResistance.GetNormalForce(fr, c));
        Assert.AreEqual(fr, RollingResistance.GetRollingResistance(c, fn));
        Assert.AreEqual(c, RollingResistance.GetRollingResistanceCoefficient(fr, fn));
    }

    [TestMethod]
    public void WeightForceTest()
    {
        var fg = 77;
        var m = 7;
        var g = 11;

        Assert.AreEqual(fg, WeightForce.GetForce(m, g));
        Assert.AreEqual(m, WeightForce.GetMass(fg, g));
        Assert.AreEqual(g, WeightForce.GetGravitationalAcceleration(fg, m));
    }
}
