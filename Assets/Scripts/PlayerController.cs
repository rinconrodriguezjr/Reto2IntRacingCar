using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Velocidad delVehiculo
    public float speed = 5.0F;
    // Velocidad del giro
    public float turnSpeed = 0.0f;

    public float horizontalInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");


        //Mover el vehiculo hacia adelante
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //Modificar el giro
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);


    }
}
