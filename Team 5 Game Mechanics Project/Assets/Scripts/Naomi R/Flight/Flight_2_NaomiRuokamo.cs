using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight_2_NaomiRuokamo : MonoBehaviour
{
    [SerializeField] private int flightSpeed, dropSpeed;
    private PlayerInputController playerInputController;
    private Rigidbody playerRigidbody;

    private void Awake()
    {
        playerRigidbody = this.gameObject.GetComponent<Rigidbody>();
        playerInputController = this.gameObject.GetComponent<PlayerInputController>();
    }

    private void Update()
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
