﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    private InputMaster playerInputActions;
    private InputAction movement;
    [SerializeField] public Player player;

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

        playerInputActions.Player.ShootBeam.performed += DoShootBeam;
        playerInputActions.Player.ShootBeam.Enable();

        playerInputActions.Player.ShootMissiles.performed += DoShootMissiles;
        playerInputActions.Player.ShootMissiles.Enable();

        playerInputActions.Player.Crouch.performed += DoCrouch;
        playerInputActions.Player.Crouch.Enable();

        playerInputActions.Player.Stand.performed += DoStand;
        playerInputActions.Player.Stand.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
        playerInputActions.Player.Jump.Disable();
        playerInputActions.Player.ShootBeam.Disable();
        playerInputActions.Player.ShootMissiles.Disable();
        playerInputActions.Player.Crouch.Disable();
        playerInputActions.Player.Stand.Disable();
    }

    private void DoJump(InputAction.CallbackContext obj)
    {
        Debug.Log("Player Controller Jump");
        player.Jump();
    }

    private void DoShootBeam(InputAction.CallbackContext obj)
    {
        //Debug.Log("Beam!");
        player.FireBeam();
    }

    private void DoShootMissiles(InputAction.CallbackContext obj)
    {
        Debug.Log("Missiles!");
    }

    private void DoCrouch(InputAction.CallbackContext obj)
    {
        Debug.Log("Crouch!");
    }

    private void DoStand(InputAction.CallbackContext obj)
    {
        Debug.Log("Stand!");
    }

    private void FixedUpdate()
    {
        //Debug.Log("Movement Values " + movement.ReadValue<float>());
        player.Walk(movement.ReadValue<float>());
        /*
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToViewportPoint(touch.position);
            if(touchPosition == )
        }
        */
    }
}
