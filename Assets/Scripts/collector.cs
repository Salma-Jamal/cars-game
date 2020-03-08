using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class collector : MonoBehaviour
{
  
    void OnTriggerEnter(Collider other)
    {

        if(other.name == "player2")
        {
            other.GetComponent<coinScore>().points++;
            Destroy(gameObject);
            

        }


    }




}
