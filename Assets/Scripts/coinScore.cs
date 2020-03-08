using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinScore : MonoBehaviour
{
    public Text coinSText;
    public int points = 0;
    
    void Update()
    {
        coinSText.text = points.ToString("0");        
    }


}
