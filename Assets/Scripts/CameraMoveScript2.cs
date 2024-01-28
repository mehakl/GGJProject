using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveScript2 : MonoBehaviour
{
    public Transform targetPosition; // Hedef pozisyon
    public float transitionSpeed = 2.0f; // Ge�i� h�z�

    private bool isTransitioning = false; // Ge�i� durumu
    private Vector3 startPosition; // Ba�lang�� pozisyonu
    private float transitionStartTime; // Ge�i�in ba�lama zaman�

    void Start()
    {
        // Kamera ba�lang�� pozisyonunu kaydet
        startPosition = transform.position;
    }

    void Update()
    {
        // E�er ge�i� yap�l�yorsa
        if (isTransitioning)
        {
            // Ge�i� zaman�n� hesapla
            float transitionProgress = (Time.time - transitionStartTime) * transitionSpeed;

            // Kamera pozisyonunu g�ncelle
            transform.position = Vector3.Lerp(startPosition, targetPosition.position, transitionProgress);

            // Ge�i� tamamland� m� kontrol et
            if (transitionProgress >= 1.0f)
            {
                isTransitioning = false;
            }
            transform.eulerAngles = Vector3.zero ; 
        }
    }

    public void StartTransition()
    {
        // E�er ge�i� yap�lm�yorsa
        if (!isTransitioning)
        {
            // Ge�i� ba�lama zaman�n� kaydet
            transitionStartTime = Time.time;

            // Ge�i�i ba�lat
            isTransitioning = true;
        }
    }
}

