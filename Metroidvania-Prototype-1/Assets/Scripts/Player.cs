using System.Collections;
using System.Collections.Generic;
using MikrosClient;
using MikrosClient.Analytics;
using UnityEngine;

public class Player : Character
{
    [SerializeField] private Beam beam;
    [SerializeField] private float speed;
    [SerializeField] private float jumpHeight;
    private AltitudeState currentAltitude;
    private float touchWalkDirection;

    // Start is called before the first frame update
    void Start()
    {
        Set();
        currentAltitude = new AirbournState();
        touchWalkDirection = 0;
    }

    // Update is called once per frame
    void Update()
    {
        IsAirbourn();
    }

    private void FixedUpdate()
    {
        Walk(touchWalkDirection);
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

    public void UpdateTouchWalkDirection(float direction)
    {
        touchWalkDirection = direction;
    }

    //Instantiates a beam object in front of the player character.
    public void FireBeam()
    {
        MikrosManager.Instance.AnalyticsController.LogEvent("Shoot Beam", (Hashtable customEventWholeData) =>
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
        transform.Translate(walkingSpeed, 0, 0);
    }

    public void Jump()
    {
        /*
        Debug.Log("player.Jump start");
        Debug.Log(currentAltitude.GetType());
        Debug.Log(typeof(GroundedState) == currentAltitude.GetType());
        */
        if(typeof(GroundedState) == currentAltitude.GetType())
        {
            MikrosManager.Instance.AnalyticsController.LogEvent("Jump", (Hashtable customEventWholeData) =>
            {
                // handle success
                Debug.Log("Jump Event Logged.");
            },
            onFailure =>
            {
                // handle failure
                Debug.Log("No Event Logged.");
            });
            StartCoroutine(JumpAction());
            //Debug.Log("Player Jump");
            currentAltitude = currentAltitude.IntoAir();
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

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Collision!");
        //Changes state to Grounded when colliding with a designated platform.
        if (collision.gameObject.tag == "Platform")
        {
            currentAltitude = currentAltitude.Land();
            //Debug.Log(currentAltitude.GetType());
        }
    }

    private void IsAirbourn()
    {
        if((GetComponent<Collider2D>().IsTouchingLayers() == false) && currentAltitude.GetType() == typeof(GroundedState))
        {
            currentAltitude = currentAltitude.IntoAir();
            //Debug.Log(currentAltitude.GetType());
        }
    }
}
