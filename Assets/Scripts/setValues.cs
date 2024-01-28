using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setValues : MonoBehaviour
{
   
    [SerializeField] private Movement movScript;
    public int health;
    public bool isDead;

    [SerializeField] private GameObject[] canvas;
    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
        movScript.movementSpeed = 350f;
        movScript.boy = 15;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0 )
        {
            isDead=true;
            health = 0;
            canvas[0].SetActive(false);
            canvas[1].SetActive(true);
        }

    }

    public void DecreaseHealth()
    {
        health--;
    }

}
