using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    

    public float boy ;
    public Transform Blok;
    Rigidbody rb;
    public float movementSpeed;
    bool isClickable;
    public int health;



    void Start()
    {
        health = 3;
       
        Blok.localScale = new Vector3(Blok.transform.localScale.x,boy,Blok.transform.localScale.z);
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.velocity = Vector3.down * (movementSpeed * Time.deltaTime);
    }
    public void onClick()
    {
        if (isClickable) 
        {
            LevelManage.score += 10;
            Destroy(gameObject);
        }
        else
        {
            health--;
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Line")
        {
           
           isClickable = true;
        }
        else
        {
            isClickable = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Line")
        {
            isClickable = false;
        }
    }
    public void BoyutDusurme(float Dusur)
    {
        if (boy >= 1)
        {
            boy -= Dusur;
        }
     
        Time.timeScale = 1;

    }

    public void increaseSpeed()
    {
        Time.timeScale = 1;
        movementSpeed *= 1.2f;
    }
}
