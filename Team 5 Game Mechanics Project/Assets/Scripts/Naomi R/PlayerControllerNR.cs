using UnityEngine;

public class PlayerControllerNR : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 500f;
    public Rigidbody myRigidbody;

    private void Update()
    {
        // get move input
        // preferred to get input in Update()
        var moveInput = Input.GetAxis("Horizontal");
        
        // set move velocity
        // preferred to interact w. physics in FixedUpdate()
        myRigidbody.velocity = new Vector3(moveInput * moveSpeed, myRigidbody.velocity.y, 0);

        // get jump input
        // preferred to get input in Update()
        var jumpInput = Input.GetKeyDown(KeyCode.Space);
        
        // apply jump force
        // preferred to interact w. physics in FixedUpdate()
        if (jumpInput && myRigidbody.velocity.y == 0)
        {
            myRigidbody.AddForce(Vector3.up * jumpForce);
        }
    }
}
