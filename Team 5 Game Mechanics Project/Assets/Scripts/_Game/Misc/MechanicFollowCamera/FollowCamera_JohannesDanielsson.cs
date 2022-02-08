using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera_JohannesDanielsson : MonoBehaviour
{
    private GameObject Player;
    private GameObject MainCamera;
    private GameObject firstPersonCamera;
    private Vector3 offset;
    // Start is called before the first frame update
    private void Awake()
    {
        MainCamera = GameObject.FindWithTag("MainCamera");
        Player = GameObject.FindGameObjectWithTag("Player");
        firstPersonCamera = GameObject.FindWithTag("FirstPersonCamera");
        offset = transform.position - Player.transform.position;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
        if (Input.GetKeyDown(KeyCode.O))
        {
            MainCamera.SetActive(false);
            firstPersonCamera.gameObject.SetActive(true);
        }
    }
}
