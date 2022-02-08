using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBullet_1_JohannesDanielsson : MonoBehaviour
{
    public GameObject Bullet;
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ShootingTheBullet();
        }
    }

    void ShootingTheBullet()
    {
       Instantiate(Bullet, new Vector3(transform.position.x+1f, transform.position.y), transform.rotation);
         
    }

   
}
