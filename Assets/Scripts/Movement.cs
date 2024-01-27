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
   private GameObject _setValues;
   
   private bool isCWrongObj;



    void Start()
    {
        _setValues=GameObject.Find("LevelManage");
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
       if(!isClickable&&_setValues.GetComponent<setValues>().health>0)
        {
            _setValues.GetComponent<setValues>().health--;
            Debug.Log(_setValues.GetComponent<setValues>().health);
        }

       if (isClickable&&isCWrongObj)
       {
           _setValues.GetComponent<setValues>().health--;
       }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Line")
        {
           
           isClickable = true;
           if (gameObject.name == "WrongObject")
           {
               isCWrongObj = true;
           }
        }
        if(other.tag==null)
        {
            isClickable = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Line")
        {
            _setValues.GetComponent<setValues>().health--; 
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

    private void OnDestroy()
    {
        
    }
}
