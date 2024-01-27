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
            gamecanvas.SetActive(false);            // OYUN TEKRAR BA�LADI�INDA SCORE HALA 50 OLDU�U ���N ISUPGRADABLE TRUE OLUYOR.
            secimekrani.SetActive(true);
            LevelManage.score = 0;
            isUpgradeble=false;
        }
        Debug.Log(LevelManage.score);
       
    }
}
