using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character : MonoBehaviour
{
    //Hit points of a character.
    protected float HP;

    //Defense of a character.
    protected float DEF;

    //Calculates damage taken from an attack.
    private float DamageCalculation(float incomingDamage)
    {
        float result = 0;
        if (incomingDamage > DEF)
        {
            result = incomingDamage - DEF;
        }
        return result;
    }
}