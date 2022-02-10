using System.Collections;
using UnityEngine;

public class Flight_1_NaomiRuokamo : MonoBehaviour
{
    [SerializeField] private float duration, floatSpeed;
    private GameObject player;
    private Rigidbody playerRigidbody;
    private bool isFloating;
    //public GameObject PowerupPrefab;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player");
        playerRigidbody = player.GetComponent<Rigidbody>();
        isFloating = false;
    }

    private void Update()
    {
        if (isFloating)
        {
            Vector3 v = new Vector3(0, floatSpeed *Time.deltaTime,0);
            player.transform.position = player.transform.position+v;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(FloatPowerUp(collision));
        }
    }

    IEnumerator FloatPowerUp(Collider collision)
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        
        playerRigidbody.useGravity = false;

        isFloating = true;

        yield return new WaitForSeconds(duration);
        
        playerRigidbody.useGravity = true;
        
        //Instantiate()
        
        isFloating = false;

        Destroy(gameObject);
    }
    
}
