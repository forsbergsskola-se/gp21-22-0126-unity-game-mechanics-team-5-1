using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightPowerUp : MonoBehaviour
{
    [SerializeField] private float duration = 5f;
    [SerializeField] private float moveSpeed = 5f;
    private PlayerInputController playerInputController;
    private GameObject player;
    private Rigidbody playerRigidbody;

    
    private void Awake()
    {
        player = GameObject.FindWithTag("Player");
        playerInputController = player.GetComponent<PlayerInputController>();
        playerRigidbody = player.GetComponent<Rigidbody>();
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
        player.GetComponent<Rigidbody>().useGravity = false;
        Flight();
        
        Debug.Log("I started waiting");
        yield return new WaitForSeconds(duration);
        Debug.Log("I finished the waiting");
        
        player.GetComponent<Rigidbody>().useGravity = true;
        
        Destroy(gameObject);
    }

    private void Flight()
    {
        var currentMoveSpeed = moveSpeed;
        playerRigidbody.velocity = new Vector3(playerInputController.FlightInput * currentMoveSpeed, playerRigidbody.velocity.y, 0);
    }
}
