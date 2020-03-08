 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded;
    public float RestartDelay = 1.6f;
    public GameObject compLevelUI;


    public void endGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("restart", RestartDelay);
        }
    } 
        void restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    public void completeLevel()
       {
        compLevelUI.SetActive(true);
        //Debug.Log("LEVEL WON!");

       }




    }

