using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class curtainOpen : MonoBehaviour
{
    public float speed;
    public bool isAvailable;
    private void Start()
    {

    }
    void Update()
    {
       if (isAvailable)
        {
            openCurtainLeft();         
        }
        
    }
    public void openCurtainLeft()
    {
        transform.localPosition += (Vector3.right * Time.deltaTime * speed);
        isAvailable = true;
        Destroy(gameObject, 5);

    }
}
