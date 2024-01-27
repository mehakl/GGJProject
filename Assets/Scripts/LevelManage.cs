using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelManage : MonoBehaviour
{
     public static int score;
     public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        scoreText.text = "Score: " +Mathf.Round(score) ;
       
    }
}
