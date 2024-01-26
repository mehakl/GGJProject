using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelManage : MonoBehaviour
{
     private int score;
    [SerializeField] private GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        scoreText.GetComponent<TMP_Text>().SetText(score.ToString());
       
    }

    public void AddScore(int point)
    {
        score += point;
    }
}
