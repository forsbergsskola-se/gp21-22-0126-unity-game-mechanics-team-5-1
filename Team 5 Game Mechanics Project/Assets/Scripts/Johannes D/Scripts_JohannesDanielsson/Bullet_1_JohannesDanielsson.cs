using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_1_JohannesDanielsson : MonoBehaviour
{
    public float bulletSpeed = 100f;
    public float bulletLife= 3f;

    public bool isGameobjectActive= true;
    public Rigidbody BulletRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        BulletRigidbody.velocity = transform.right* bulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        BulletGetsDestoyed();
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }

    private void BulletGetsDestoyed()
    {
        //TODO I know that the bool is not needed but I am thinking of implementing differently later on. 
        if (isGameobjectActive)
        {
            Destroy(gameObject, bulletLife);
        }
    }
    
}
