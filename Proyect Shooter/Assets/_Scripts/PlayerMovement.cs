using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]//esto es para que si o si al objeto que quieras meter el script, tenga un rigidbody, si no la tenes, unity te la pone automaticamente.
public class PlayerMovement : MonoBehaviour
{

    [Tooltip("FUERZA de movimiento del personaje en N/S")]
    [Range(0, 1000)]
    public float speed;

    [Tooltip ("FUERZA de Rotacion del personaje en NEWTON*SEG")]
    [Range(0,180)]
    public float rotationSpeed;

    private Rigidbody rb;

    void Start() 
    {
        Cursor.visible = false; //para hacer que el cursor no sea visible
        Cursor.lockState =CursorLockMode.Locked; //para que el cursor no se mueva.

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // epacio es S = velocidad x tiempo
        // incremento de S = V x incr T
        float space = speed * Time.deltaTime;

        float horizontal =Input.GetAxis("Horizontal"); //-1 a 1
        float vertical = Input.GetAxis("Vertical"); // -1 a 1
        
        //el vector3 se utiliza para que si se mueve en diagonal, no se mueva mas rapido que lo comun
        Vector3 dir = new Vector3 (x:horizontal, y:0, z:vertical);
        //transform.Translate(translation: dir.normalized*space); estas lineas deben ser remplazadas por una fuerza de traslacion. esto sucede cuando son objetos que aplican o le aplican fuerza
        rb.AddRelativeForce (dir.normalized*space);

        float angle = rotationSpeed*Time.deltaTime;
        float mouseX =Input.GetAxis("Mouse X");
        //transform.Rotate(xAngle:0,yAngle:mouseX*angle,zAngle:0); estas lineas deben ser remplazadas por una fuerza de rotacion ---torque.
        rb.AddRelativeTorque(0,mouseX*angle,0);

        /*
        if(Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(x:0, y:0, z:space); 
        }

        if(Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(x:0, y:0, z:-space); 
        }
        if(Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(x:space, y:0, z:0); 
        }
        if(Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(x:-space, y:0, z:0); 
        }
        */
    }
}
