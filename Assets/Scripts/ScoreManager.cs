using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    

    public Text ScoreText ; 
    public float score ; 
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player")!= null)
          {
              score +=1*Time.deltaTime;
              ScoreText.text = ((int )score).ToString(); 
              
          }
    }
}
