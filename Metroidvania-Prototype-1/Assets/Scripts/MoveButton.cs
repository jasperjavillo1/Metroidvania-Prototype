using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButton : MonoBehaviour
{
    [SerializeField] public float direction;
    public float movement = 0;
    [SerializeField] public Player player;

    private void OnEnable()
    {
        player = FindObjectOfType<Player>();
    }

    private void OnMouseDown()
    {
        movement = direction;
        Debug.Log(movement);
    }

    private void OnMouseUpAsButton()
    {
        movement = 0;
        Debug.Log(movement);
    }

    private void FixedUpdate()
    {
        player.Walk(movement);
    }
}
