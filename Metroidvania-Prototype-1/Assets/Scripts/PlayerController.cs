using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private InputMaster playerInputActions;
    private InputAction movement;

    private void Awake()
    {
        playerInputActions = new InputMaster();
    }

    private void OnEnable()
    {
        movement = playerInputActions.Player.Move;
        movement.Enable();

        playerInputActions.Player.Jump.performed += DoJump;
        playerInputActions.Player.Jump.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
        playerInputActions.Player.Jump.Disable();
    }

    private void DoJump(InputAction.CallbackContext obj)
    {
        Debug.Log("Jump!");
    }

    private void FixedUpdate()
    {
        Debug.Log("Movement Values " + movement.ReadValue<float>());
    }
}
