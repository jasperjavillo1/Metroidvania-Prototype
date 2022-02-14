using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Beam : Attack
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Forward());
        StartCoroutine(DelayedDestruct());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Forward()
    {
        while(true)
        {
            yield return null;
            transform.Translate(speed,0,0);
        }
    }

    IEnumerator DelayedDestruct()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }
}
