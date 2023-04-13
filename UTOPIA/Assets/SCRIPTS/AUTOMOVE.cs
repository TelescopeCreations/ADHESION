using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AUTOMOVE : MonoBehaviour
{   
    GameManagerr GameManger;
    // Start is called before the first frame update
    void Start()
    {
       GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
       GameManger=gameController.GetComponent<GameManagerr>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(GameManger.moveVector * GameManger.moveSpeed * Time.deltaTime);
    }
}
