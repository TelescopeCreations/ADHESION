using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LEVELCHANGE : MonoBehaviour
{   
    public GameObject Leveltimer;

    void Levelchange()
   {    //LOADS NEXT LEVEL 
        //Enables Levelchange
        Leveltimer.SetActive(true);
        StartCoroutine(Levelchanger());
    }
    //
        IEnumerator Levelchanger() {
        yield return new WaitForSeconds (30f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
        
   }
