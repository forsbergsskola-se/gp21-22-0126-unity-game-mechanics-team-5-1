using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript_Johannes_Danielsson : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        NextLevel();
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
