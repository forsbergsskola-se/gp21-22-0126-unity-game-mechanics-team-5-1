using System.Collections;
using UnityEngine;

public class FlightPowerUp : MonoBehaviour
{
    [SerializeField] private float duration = 3f, flightSpeed;
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
            Vector3 v = new Vector3(0, flightSpeed *Time.deltaTime,0);
            player.transform.position = player.transform.position+v;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("power up was picked up");
            StartCoroutine(PowerUp(collision));
        }
    }

    IEnumerator PowerUp(Collider collision)
    {
        Debug.Log("I started the coroutine");

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        
        playerRigidbody.useGravity = false;

        isFlying = true;
        
        Debug.Log("I started waiting");
        yield return new WaitForSeconds(duration);
        Debug.Log("I finished the waiting");

        playerRigidbody.useGravity = true;
        
        isFlying = false;
        
        Destroy(gameObject);
    }
    
}
