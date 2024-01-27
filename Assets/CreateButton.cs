using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CreateButton : MonoBehaviour
{
   
    [SerializeField] private GameObject button;
    [SerializeField] private RectTransform spawnPoint;
    public float nextSpawn = 2f;
    public float spawnRate = 1f;
    GameObject cloneObject;
    
    private void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            cloneObject= Instantiate(button, spawnPoint.transform.position, Quaternion.identity);
            cloneObject.transform.SetParent(spawnPoint.transform.parent);
            cloneObject.transform.localScale = new Vector3(0.35f,1f,1f);
        }
    }
    
}
