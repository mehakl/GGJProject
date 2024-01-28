using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterAnim : MonoBehaviour
{
    Animator anim;
    [SerializeField] setValues sValue;
    bool isD;
    // Start is called before the first frame update
    void Start()
    {
        anim= GetComponent<Animator>(); 
        
    }
    private void Update()
    {
        isD = sValue.isDead;
    }

    // Update is called once per frame
    private void OnAnimatorMove()
    {
        if (isD)
        {
            anim.SetBool("isDead", true);
        }
    }
}
