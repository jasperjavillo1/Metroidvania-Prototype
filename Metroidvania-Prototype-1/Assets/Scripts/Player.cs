using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public GameObject beam;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
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

    //Below is the State Machine, which controls when certain action can occur based on the player character's current condition.
    class PlayerState
    {
        public virtual PlayerState handleInput()
        {
            return this;
        }
    }

    //When the player is idle on the ground.
    class IdleState : PlayerState
    {
        public override PlayerState handleInput()
        {
            return base.handleInput();
        }
    }

    //when the player is airbourn.
    class AirbournState : PlayerState
    {
        public override PlayerState handleInput()
        {
            return base.handleInput();
        }
    }
}
