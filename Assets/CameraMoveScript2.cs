using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveScript2 : MonoBehaviour
{
    public Transform targetPosition; // Hedef pozisyon
    public float transitionSpeed = 2.0f; // Geçiþ hýzý

    private bool isTransitioning = false; // Geçiþ durumu
    private Vector3 startPosition; // Baþlangýç pozisyonu
    private float transitionStartTime; // Geçiþin baþlama zamaný

    void Start()
    {
        // Kamera baþlangýç pozisyonunu kaydet
        startPosition = transform.position;
    }

    void Update()
    {
        // Eðer geçiþ yapýlýyorsa
        if (isTransitioning)
        {
            // Geçiþ zamanýný hesapla
            float transitionProgress = (Time.time - transitionStartTime) * transitionSpeed;

            // Kamera pozisyonunu güncelle
            transform.position = Vector3.Lerp(startPosition, targetPosition.position, transitionProgress);

            // Geçiþ tamamlandý mý kontrol et
            if (transitionProgress >= 1.0f)
            {
                isTransitioning = false;
            }
            transform.eulerAngles = Vector3.zero ; 
        }
    }

    public void StartTransition()
    {
        // Eðer geçiþ yapýlmýyorsa
        if (!isTransitioning)
        {
            // Geçiþ baþlama zamanýný kaydet
            transitionStartTime = Time.time;

            // Geçiþi baþlat
            isTransitioning = true;
        }
    }
}

