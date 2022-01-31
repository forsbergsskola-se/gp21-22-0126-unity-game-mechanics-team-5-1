using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 100f;
    public float bulletLife= 3;

    public Rigidbody BulletRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        BulletRigidbody.velocity = transform.right* bulletSpeed;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}
