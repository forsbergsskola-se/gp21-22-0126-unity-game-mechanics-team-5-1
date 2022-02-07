using System.Collections;
using UnityEngine;

public class Flight_1_NaomiRuokamo : MonoBehaviour
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
            StartCoroutine(PowerUp(collision));
        }
    }

    IEnumerator PowerUp(Collider collision)
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
