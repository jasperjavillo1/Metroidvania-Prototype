using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedState : AltitudeState
{
    public override AltitudeState Jump()
    {
        Debug.Log("Grounded State Jump");
        return new AirbournState();
    }

    public override AltitudeState IntoAir()
    {
        return new AirbournState();
    }

    public override AltitudeState Land()
    {
        return this;
    }
}
