using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        scoreText.text = "Score: " + score;
       
    }
    
    public void IncreaseScore(int amount)
        {
            score+= amount;
         }   
}
