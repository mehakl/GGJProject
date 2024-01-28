using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curtainOpenRight : MonoBehaviour
{
    public bool isAvailable;
    public float speed;
    void Update()
    {
        if (isAvailable)
        curtainOpenR();
        
    }
    public void curtainOpenR()
    {
        transform.localPosition += (Vector3.left * Time.deltaTime * speed);
        isAvailable = true;
        Destroy(gameObject, 5);
    }
}
