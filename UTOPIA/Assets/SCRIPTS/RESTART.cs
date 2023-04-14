using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class RESTART : MonoBehaviour
{

    public string levelToLoad;
    public float timer = 10f;
    private Text timerSeconds;
    // Start is called before the first frame update
    void Start()
    {
        timerSeconds =GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer<=0)
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
