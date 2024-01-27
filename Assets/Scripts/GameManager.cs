using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gamecanvas, secimekrani;
    public bool isUpgradeble;
    
    void Start()
    {
        
    }

    private void LateUpdate()
    {
        if (LevelManage.score == 50)
        isUpgradeble = true;

    }
    void Update()
    {
        if (isUpgradeble)
        {    
            Time.timeScale = 0;
            gamecanvas.SetActive(false);            // OYUN TEKRAR BAÞLADIÐINDA SCORE HALA 50 OLDUÐU ÝÇÝN ISUPGRADABLE TRUE OLUYOR.
            secimekrani.SetActive(true);   
            isUpgradeble=false;
        }
       
    }
}
