using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoteLight : MonoBehaviour
{
    private int health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        health = GameObject.Find("LevelManage").GetComponent<setValues>().health;
        
        for (int i = 0; i <transform.childCount-health && health>=0; i++)
        {
            gameObject.transform.GetChild(i).GetComponent<MeshRenderer>().material.color=Color.red;

        } 
    }
  
}
