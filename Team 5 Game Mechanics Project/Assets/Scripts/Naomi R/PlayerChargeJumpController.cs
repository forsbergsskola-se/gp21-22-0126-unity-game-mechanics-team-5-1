using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChargeJumpController : MonoBehaviour
{
    private Rigidbody myRigidbody;
    private PlayerInputController playerInputController;
    private GroundChecker groundChecker;
    [SerializeField] private float minimumJumpForce = 100f;
    [SerializeField] private float maximumJumpForce = 1000f;
    [SerializeField] private float chargeTime = 1f;

    private float jumpCharge;
    
    private void Awake()
    {
        myRigidbody = this.gameObject.GetComponent<Rigidbody>();
        playerInputController = this.gameObject.GetComponent<PlayerInputController>();
        groundChecker = this.gameObject.GetComponent<GroundChecker>();
    }

    private void Update()
    {
        if (playerInputController.JumpInput)
            jumpCharge += Time.deltaTime / chargeTime;

        if (playerInputController.JumpInputUp)
        {
            var jumpForce = Mathf.Lerp(minimumJumpForce, maximumJumpForce, jumpCharge);
            jumpCharge = 0f;

            if (groundChecker.IsGrounded)
                myRigidbody.AddForce(Vector3.up * jumpForce);
        }
    }
}