using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{
    private Rigidbody myRigidbody;
    private PlayerInputController playerInputController;
    private GroundChecker groundChecker;
    [SerializeField] private float jumpForce = 500f;

    private void Awake()
    {
        myRigidbody = this.gameObject.GetComponent<Rigidbody>();
        playerInputController = this.gameObject.GetComponent<PlayerInputController>();
        groundChecker = this.gameObject.GetComponent<GroundChecker>();
    }

    private void Update()
    {
        //Apply jump force
        //Preferably interact with physics in FixedUpdate() 
        if (playerInputController.JumpInputDown && groundChecker.IsGrounded)
            myRigidbody.AddForce(Vector3.up * jumpForce);
    }
}
