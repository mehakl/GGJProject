using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setValues : MonoBehaviour
{
    [SerializeField] private Movement movScript;
    public int health;

    [SerializeField] private GameObject[] canvas;
    // Start is called before the first frame update
    void Start()
    {
        movScript.movementSpeed = 3500f;
        movScript.boy = 10;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            canvas[0].SetActive(false);
            canvas[1].SetActive(true);
        }
    }
}
