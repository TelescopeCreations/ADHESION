using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightController2 : MonoBehaviour
{   
    public float movementspeed = 10f;
    public float hoverspeed = 5f;


// Update is called once per frame    
void Update() {
    float verticalInput = Input.GetAxis("Vertical");
    float horizontalInput = Input.GetAxis("Horizontal");
    float activehoverspeed = Input.GetAxis("Hover") * hoverspeed;
    
    
    Debug.Log("V-> " + verticalInput);
    Debug.Log("H-> " + horizontalInput);
    Debug.Log("Hovering-> " + activehoverspeed);

    Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
    movement.Normalize();
    transform.Translate(movement * movementspeed * Time.deltaTime);
  
}
}