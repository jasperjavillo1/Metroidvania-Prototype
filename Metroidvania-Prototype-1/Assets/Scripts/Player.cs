using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public GameObject beam;
    public float speed;

    public AltitudeState CurrentAltitude = new AirbournState();
    // Start is called before the first frame update
    void Start()
    {
        StartCorutine(isAirbourn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void set()
    {
        HP = 99;
        DEF = 100;
    }

    private void checkGameOver()
    {
        if (HP <= 0)
        {
            //game over event
        }
    }

    //Instantiates a beam object in front of the player character.
    public void fireBeam()
    {
        Vector3 spawnPoint = transform.position + new Vector3(1,0,0);
        Instantiate(beam, spawnPoint, Quaternion.identity);
    }

    //Move player along X-axis
    public void walk(float direction)
    {
        float walkingSpeed = speed * direction;
        transform.Translate(walkingSpeed,0,0);
    }

    public void jump()
    {
        if(CurrentAltitude.GetType() == typeof(GroundedState))
        {
            transform.Translate(0,1,0);
            CurrentAltitude = CurrentAltitude.intoAir();
            Debug.Log("Jump");
        }
    }

    IEnumerator isAirbourn()
    {
        yield return null;
        while(true)
        {
            if(IsTouchingLayers(9) == false)
            {
                CurrentAltitude = CurrentAltitude.intoAir();
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision!");
        if (collision.gameObject.tag == "Platform")
        {
            CurrentAltitude = CurrentAltitude.land();
            Debug.Log("Landed!");
        }
    }

    //Below is the State Machine, which controls when certain action can occur based on the player character's current condition.
    public class AltitudeState
    {
        public virtual AltitudeState intoAir()
        {
            return this;
        }
        public virtual AltitudeState land()
        {
            return this;
        }
    }

    //When the player is idle on the ground.
    class GroundedState : AltitudeState
    {
        public override AltitudeState intoAir()
        {
            return new AirbournState();
        }
    }

    //when the player is airbourn.
    class AirbournState : AltitudeState
    {
        public override AltitudeState land()
        {
            return new GroundedState();
        }
    }
}
