using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class onGameCanvas : MonoBehaviour
{
    [SerializeField] GameObject gameCanvas;

    void Start()
    {

    }


    void Update()
    {

    }
    public async void openCanvas()
    {
        await Task.Delay(5000);
        if (gameCanvas != null) 
        gameCanvas.SetActive(true);
    }
}