using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath_JohannesDanielsson : MonoBehaviour
{
    private bool playerAktiv = true;
    [SerializeField]private GameObject player;

    // Update is called once per frame
    void Update()
    {
       Death();
        
    }
    private IEnumerator startLevel()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void Death()
    {
        if (player.transform.position.y <= -2&& playerAktiv)
        {
            player.gameObject.SetActive(false);
            playerAktiv = false;
        }
        if (playerAktiv == false)
        {
            StartCoroutine(startLevel());
        }
    } 
}
