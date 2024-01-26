using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    public float movementSpeed;
    bool isClickable;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.velocity = Vector3.down*movementSpeed*Time.deltaTime;
    }
    public void onClick()
    {
        if(isClickable) 
        Destroy(gameObject);

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag ("Line") )
        {
           
           isClickable = true;
        }
    }
}