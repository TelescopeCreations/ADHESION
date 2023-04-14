using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WINDGATEOPEN : MonoBehaviour
{
   public GameObject gate;

    void OnTriggerEnter(Collider player)
    {   
        if(player.tag == "WIND")
        {
        //Enables Jumpscare
        gate.SetActive(false);
        StartCoroutine(OpenGate());
        }
    }
//
   IEnumerator OpenGate() {
        yield return new WaitForSeconds (3.5f);
        gate.SetActive(true);
   }
}