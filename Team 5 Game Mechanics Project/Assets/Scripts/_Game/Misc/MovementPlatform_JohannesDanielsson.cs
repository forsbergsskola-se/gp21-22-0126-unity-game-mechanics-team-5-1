using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlatform_JohannesDanielsson : MonoBehaviour
{
   public GameObject Player;

   private void OnTriggerEnter(Collider other)
   {
      if (other.gameObject== Player)
      {
         Player.transform.parent = transform;
      }
   }

   private void OnTriggerExit(Collider other)
   {
      if (other.gameObject== Player)
      {
         Player.transform.parent = null;
      }
      
   }
}
