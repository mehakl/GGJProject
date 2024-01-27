using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setValues : MonoBehaviour
{
    [SerializeField] private Movement movScript;
    // Start is called before the first frame update
    void Start()
    {
        movScript.movementSpeed = 3000f;
        movScript.boy = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
