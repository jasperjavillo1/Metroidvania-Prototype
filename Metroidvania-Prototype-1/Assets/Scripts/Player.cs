using System.Collections;
using System.Collections.Generic;
using MikrosApiClient;
using MikrosApiClient.MikrosAnalytics;
using UnityEngine;

public class Player : Character
{
    public GameObject beam;
    public float speed;
    public float jumpHeight;

    public AltitudeState CurrentAltitude = new AirbournState();
    // Start is called before the first frame update
    void Start()
    {
        Set();
    }

    // Update is called once per frame
    void Update()
    {
        IsAirbourn();
    }

    private void Set()
    {
        HP = 99;
        DEF = 100;
    }

    private void CheckGameOver()
    {
        if (HP <= 0)
        {
            //game over event
        }
    }

    //Instantiates a beam object in front of the player character.
    public void FireBeam()
    {
        MikrosManager.Instance.AnalyticsController.LogEvent("shoot", (Hashtable customEventWholeData) =>
        {
            // handle success
            Debug.Log("Beam Event Logged.");
        },
        onFailure =>
        {
           // handle failure
           Debug.Log("No Event Logged.");
        });
        Vector3 spawnPoint = transform.position + new Vector3(1,0,0);
        Instantiate(beam, spawnPoint, Quaternion.identity);
    }

    //Move player along X-axis
    public void Walk(float direction)
    {
        float walkingSpeed = speed * direction;
        transform.Translate(walkingSpeed,0,0);
    }

    public void Jump()
    {
        if(CurrentAltitude.GetType() == typeof(GroundedState))
        {  
            MikrosManager.Instance.AnalyticsController.LogEvent("player_jump", (Hashtable customEventWholeData) =>
            {
                // handle success
                Debug.Log("Jump Event Logged.");
            },
            onFailure =>
            {
               // handle failure
               Debug.Log("No Event Logged.");
            });
            CurrentAltitude = CurrentAltitude.IntoAir();
            StartCoroutine(JumpAction());
            Debug.Log("Jump");
        }
    }

    IEnumerator JumpAction()
    {
        for(int i = 0; i < jumpHeight; i++)
        {
            transform.Translate(0,1,0);
            yield return new WaitForFixedUpdate();
        }
    }

    //Once started, will constantly check if Player is touching a Platform and set state to Airbourn if it is not.

    private void IsAirbourn()
    {
        //Collider2D collider = this.GetComponent<Collider2D>();
        if(GetComponent<Collider2D>().IsTouchingLayers() == false)
        {
            CurrentAltitude = CurrentAltitude.IntoAir();
            //Debug.Log("In Air!");
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision!");
        //Changes state to Grounded when colliding with a designated platform.
        if (collision.gameObject.tag == "Platform")
        {
            CurrentAltitude = CurrentAltitude.Land();
        }
    }

    //Below is the State Machine, which controls when certain action can occur based on the player character's current condition.
    public class AltitudeState
    {
        public virtual AltitudeState IntoAir()
        {
            return this;
        }
        public virtual AltitudeState Land()
        {
            return this;
        }
    }

    //When the player is idle on the ground.
    class GroundedState : AltitudeState
    {
        public override AltitudeState IntoAir()
        {
            return new AirbournState();
        }
    }

    //when the player is airbourn.
    class AirbournState : AltitudeState
    {
        public override AltitudeState Land()
        {
            return new GroundedState();
        }
    }
}
