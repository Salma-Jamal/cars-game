using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 2000f;
    public float SidewaysForce = 500f;
    
   
  
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForce* Time.deltaTime);

        if(Input.GetKey("d"))
        {
          rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1.7)
        {
            FindObjectOfType<GameManager>().endGame();

        }


  

      


    }
}
