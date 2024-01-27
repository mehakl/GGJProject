using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CreateButton : MonoBehaviour
{
    
    [SerializeField] GameObject button;
    [SerializeField] private RectTransform spawnPoint;
    public float SpawnRateMin = 2f;
    public float SpawnRateMax = 2.8f;
    public float SpawnRate;
    public float nextSpawn = 2f;
    GameObject cloneObject;

    private void LateUpdate()
    {
        SpawnRate = Random.Range(SpawnRateMin, SpawnRateMax);
    }
    private void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + SpawnRate;
            cloneObject= Instantiate(button, spawnPoint.transform.position, Quaternion.identity);
            cloneObject.transform.SetParent(spawnPoint.transform.parent);
            cloneObject.transform.localScale = new Vector3(button.transform.localScale.x, button.transform.localScale.y, button.transform.localScale.z);
        }
    }
    public void SpeedArttirma(float Speed)
    {
        SpawnRateMin -= Speed;
        SpawnRateMax -= Speed;
    }
    
}
