# Physics Formulas

## Overview

This library is a collection of some formulas known from physics.
Each formula is represented by a `static class` and solved once for every symbol in a separate method.
The formular for steady motion `v=s/t` with `v` beeing the velocity, `s` the distance and `t` the duration is represented by the class `PhysicsFormulas.Mechanics.Translation.SteadyMotion`: 
```cshape
var v = SteadyMotion.GetVelocity(s, t);
var s = SteadyMotion.GetDistance(v, t);
var t = SteadyMotion.GetDuration(s, v);
```

Currently the following formulas are supported:
* Mechanics
  * Energy
    * Mechanical Work (W = F * s)
    * Power (P = dW/dt)
  * Force
    * Acceleration Force (F = (e * massVehicle + massLoad) * a)
    * Air Resistance (F = cw * area * airDensity * relativeVelocity² / 2)
    * Downhill Force (F = Fg * sin(alpha))
    * Normal Force (Fn = Fg * cos(alpha))
    * Rolling Resistance (Fr = c * Fn)
    * Wieght Force (Fg = m * g)
  * Translation
    * Steady Motion (s = v * t)
    * Uniform acceleration (s = 0.5*a*t² + v0*t and a = dv/dt)

Feel free to create a pull request to add missing formulas.

## Units

This library always assumes (SI base units)[https://en.wikipedia.org/wiki/SI_base_unit]. But the units are additionally stated in [square brackets] in each method:

![image](https://user-images.githubusercontent.com/5458773/115216638-fce8fa00-a104-11eb-8885-ea0a3edb7887.png)

