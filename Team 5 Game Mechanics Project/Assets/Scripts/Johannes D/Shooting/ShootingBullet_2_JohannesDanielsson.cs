using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBullet_2_JohannesDanielsson : MonoBehaviour
{
    [SerializeField] private GameObject Bullet;
    public float BurstFireRate = 0.3f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartCoroutine(ShootBurst());
        }
    }

    void ShootingTheBullet()
    {
       
    }

    IEnumerator ShootBurst()
    {
        Instantiate(Bullet, new Vector3(transform.position.x + 1f, transform.position.y), transform.rotation);
        yield return new WaitForSeconds(BurstFireRate);
        Instantiate(Bullet, new Vector3(transform.position.x + 1f, transform.position.y), transform.rotation);
        yield return new WaitForSeconds(BurstFireRate);
        Instantiate(Bullet, new Vector3(transform.position.x + 1f, transform.position.y), transform.rotation);
        yield return new WaitForSeconds(BurstFireRate);
    }

   
}
