using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highS1 : MonoBehaviour
{
    public score scoreobj;
    public Text HS1Text;
   // public coinScore cs;
    int scoreTemp;
    

    void Update()
    {
        //scoreTemp = int.Parse(scoreobj.scoreText.text) * cs.points; 
        //int.Parse(scoreobj.scoreText.text) * cs.points ;
        // int.Parse(gamesPlayedText.text);
        HS1Text.text = scoreobj.scoreText.text;

    }
}
