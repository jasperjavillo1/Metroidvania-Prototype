using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public GameObject beam;
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

    private void fireBeam()
    {
        Instantiate(beam, new Vector3(1,0,0),Quaternion.identity);
    }
}
