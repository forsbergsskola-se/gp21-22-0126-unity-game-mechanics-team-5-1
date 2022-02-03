using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
    private Rigidbody myRigidbody;
    private PlayerInputController playerInputController; 
    private GroundChecker groundChecker;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float chargingMoveSpeedFactor = 0.5f;
    private bool facingRight= true;
    private bool startGame = true;
    [SerializeField] private GameObject firstPersonCamera;
    
    private void Awake()
    {
        myRigidbody = this.gameObject.GetComponent<Rigidbody>();
        playerInputController = this.gameObject.GetComponent<PlayerInputController>();
        groundChecker = this.gameObject.GetComponent<GroundChecker>();
    }

    private void Update()
    {
        //Slower move speed while charging a jump.
        var currentMoveSpeed = moveSpeed;
        if (playerInputController.JumpInput && groundChecker.IsGrounded)
            currentMoveSpeed *= chargingMoveSpeedFactor;

        myRigidbody.velocity = new Vector3(playerInputController.MoveInput * currentMoveSpeed, myRigidbody.velocity.y, 0);
        if (playerInputController.MoveInput<0 && facingRight)
        {
            flip();
        }
        else if (playerInputController.MoveInput>0 && !facingRight)
        {
            flip();
        }
    }

    private void FixedUpdate()
    {
        // if (playerInputController.MoveInputHorizontal<0 && facingRight)
        // {
        //     flip();
        // }
        // else if (playerInputController.MoveInputHorizontal>0 && !facingRight)
        // {
        //     flip();
        // }
    }

    void flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0, 180f,0 );
        if (startGame==false)
        {
            facingRight = !facingRight;
            firstPersonCamera.transform.Rotate(0,180,0);
        }
    }
}