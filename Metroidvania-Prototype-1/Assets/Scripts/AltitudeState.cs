using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltitudeState
{
    public virtual AltitudeState Jump()
    {
        return this;
    }

    public virtual AltitudeState IntoAir()
    {
        return this;
    }
    public virtual AltitudeState Land()
    {
        return this;
    }
}
