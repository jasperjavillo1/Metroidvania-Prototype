using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirbournState : AltitudeState
{
    public override AltitudeState Jump()
    {
        return this;
    }

    public override AltitudeState IntoAir()
    {
        return this;
    }

    public override AltitudeState Land()
    {
        return new GroundedState();
    }
}
