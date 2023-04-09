using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SWAY2 : MonoBehaviour
{
    [SerializeField] float period = 4f;
    public float swayPower = 0.5f;

     public Transform playerBody;
     

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (period <= 0f){ return; }
        float cycles = Time.time / period;
        const float tau = Mathf.PI * 2;
        float rawSineWave = Mathf.Sin(cycles * tau);
        Debug.Log(rawSineWave);

         playerBody.Rotate(Vector3.up * (rawSineWave)* swayPower);
    }

    /*public void msway()
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
    }*/
}
