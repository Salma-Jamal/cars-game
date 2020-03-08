using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collistion : MonoBehaviour
{
    public playerMovement movement;
    //public GameManager gameM;

   void OnCollisionEnter(Collision info) 
    {
        if(info.collider.tag == "obstacle")
        {
            //Debug.Log("we hit an obstacle");
            movement.enabled = false;
            FindObjectOfType<GameManager>().endGame();

        }


    }
}
