using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManage : MonoBehaviour
{
     public static int score;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
         
       
    }
    public void loadCanvas()
    {
        SceneManager.LoadScene(0);
    }
}
