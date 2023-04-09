using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSway : MonoBehaviour
{
    public float sway = 0.01f;
    public float swayLimit = 4.01f;
    public float mouseSensitivity = 10000f;
    public bool atswayborder = false;
    //public float mouseX = 0.001f;

    public Transform playerBody;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {   
       // float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
    
        
       msway();
    }

    public void msway()
    {   
        //mouse sway functionality
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
       
       
        Debug.Log("Called");
        for(float i = 0.01f; i <= swayLimit; i++)
        { 
            if(i==4.01)
            {
                Debug.Log("IT BROKE");
                playerBody.Rotate(Vector3.up * (sway));
                break;    
            }
           //Debug.Log(mouseX);
           Debug.Log((i) +(" Going left"));
           playerBody.Rotate(Vector3.up * (sway));
           
        }
    }
}   
    
