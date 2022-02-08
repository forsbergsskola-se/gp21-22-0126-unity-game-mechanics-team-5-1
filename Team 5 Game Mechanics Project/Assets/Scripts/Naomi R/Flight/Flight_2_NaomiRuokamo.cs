using System.Collections;
using UnityEngine;

public class Flight_2_NaomiRuokamo : MonoBehaviour
{
    [SerializeField] private int flightSpeed, dropSpeed, duration;
    private GameObject player;
    private Rigidbody playerRigidbody;
    private bool isFlying;


    private void Awake()
    {
        player = GameObject.FindWithTag("Player");
        playerRigidbody = player.GetComponent<Rigidbody>();
        isFlying = false;
    }
    

    private void Update()
    {
        if (isFlying)
        {
            if (Input.GetKey(KeyCode.W))
            {
                playerRigidbody.AddForce(Vector3.up * flightSpeed);
            }

            if (Input.GetKey(KeyCode.S))
            {
                playerRigidbody.AddForce(Vector3.down * dropSpeed);
            }
        }
    }
    
    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(FlyPowerUp(collision));
        }
    }

    IEnumerator FlyPowerUp(Collider collision)
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        
        playerRigidbody.useGravity = false;

        isFlying = true;
        
        yield return new WaitForSeconds(duration);

        playerRigidbody.useGravity = true;
        
        isFlying = false;
        
        Destroy(gameObject);
    }
}
