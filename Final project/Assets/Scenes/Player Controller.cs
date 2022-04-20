using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    
    public float speed = 5f; 

    private PlayerMotor motor; 

    void Start ()
    {
        motor = GetComponent<PlayerMotor>(); 
    }

    void Update ()
    {
        //Calculate movement velocity as a 3D vector 
        float xMov = Input.GetAxisRaw("Horizontal"); 
        float zMov = Input.GetAxisRaw("Vertical");  

        Vector3 _movHorizontal = transform.right * xMov; 
        Vector3 _movVertical = transform.forward * zMov; 

        // Final movement vector 
        Vector3 _velocity = ( _movHorizontal + _movVertical).normalized * speed;

        //Apply movement 
        motor.Move(_velocity); 
    }


}
