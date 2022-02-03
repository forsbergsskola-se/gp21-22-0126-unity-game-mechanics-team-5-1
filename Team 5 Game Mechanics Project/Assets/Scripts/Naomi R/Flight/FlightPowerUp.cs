using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightPowerUp : MonoBehaviour
{
    [SerializeField] private float duration = 5f;
    private PlayerInputController playerInputController;
    private GameObject player;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player");
        playerInputController = player.GetComponent<PlayerInputController>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("power up was picked up");
            StartCoroutine(PowerUp(collision));
        }
    }

    IEnumerator PowerUp(Collider player)
    {
        Debug.Log("I started the coroutine");

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        
        yield return new WaitForSeconds(duration);
        Debug.Log("I finished the waiting");
        
        Destroy(gameObject);
    }
}
