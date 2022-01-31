using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightPowerUp : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("power up was picked up");
        }
        Destroy(this.gameObject);
    }
}
