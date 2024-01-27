using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Upgrades : MonoBehaviour
{
    [SerializeField] GameObject gamecanvas, secimekrani;
    
    private CreateButton createButon;
    private float spawnRateMin;
    private float spawnRateMax;
    private float boy;
    private void Awake()
    {
        createButon = FindObjectOfType<CreateButton>();
        if (createButon != null)
        {
            spawnRateMin = createButon.SpawnRateMin;
            spawnRateMax = createButon.SpawnRateMax;

        }
    }
    

    public void Speed() 
    {
        
        createButon.SpeedArttirma(0.2f);
        Time.timeScale = 1;
        gamecanvas.SetActive(true);
        secimekrani.SetActive(false);
        
    }

    void Update()
    {
        
    }
}
