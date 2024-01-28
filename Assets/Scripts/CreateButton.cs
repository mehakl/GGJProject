using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UIElements.Image;
using Random = UnityEngine.Random;

public class CreateButton : MonoBehaviour
{
    [SerializeField] private float rotZ;
    [SerializeField] GameObject button;
    [SerializeField] private RectTransform spawnPoint;
    public float SpawnRateMin = 2f;
    public float SpawnRateMax = 2.8f;
    public float SpawnRate;
    public float nextSpawn = 2f;
    private int countFRand;
    private int count;
    GameObject cloneObject;

    private void Start()
    {
        count = 0;
        countFRand = Random.Range(3, 5);
    }

    private void LateUpdate()
    {
        
        SpawnRate = Random.Range(SpawnRateMin, SpawnRateMax);
    }
    private void Update()
    {
        if (Time.time > nextSpawn&&count!=countFRand)
        {
            nextSpawn = Time.time + SpawnRate;
            cloneObject= Instantiate(button, spawnPoint.transform.position, Quaternion.identity);
            cloneObject.transform.SetParent(spawnPoint.transform.parent);
            cloneObject.transform.localScale = new Vector3(button.transform.localScale.x, button.transform.localScale.y, button.transform.localScale.z);
          
            cloneObject.transform.Rotate(0,0,rotZ);
            count++;
           Invoke("createRandomObject",2);
        

        }
     
    }
    public void SpeedArttirma(float Speed)
    {
        SpawnRateMin -= Speed;
        SpawnRateMax -= Speed;
    }

    void createRandomObject()
    {
        if (count == countFRand)
        {
            
            cloneObject= Instantiate(button, spawnPoint.transform.position, Quaternion.identity);
            cloneObject.transform.SetParent(spawnPoint.transform.parent);
            cloneObject.transform.localScale = new Vector3(button.transform.localScale.x, button.transform.localScale.y, button.transform.localScale.z);
            cloneObject.name = "WrongObject";
            countFRand = Random.Range(3, 5);
            count = 0;
        }
    }
    
}
