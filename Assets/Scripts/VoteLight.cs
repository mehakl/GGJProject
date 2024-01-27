using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoteLight : MonoBehaviour
{
    Animator animator;
    [SerializeField] Movement mov;
    // Start is called before the first frame update
    void Start()
    {
        animator= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnAnimatorMove()
    {
        if (animator != null && mov.enabled)
        {
            if(mov.health==0)
            {
                animator.SetBool("turnRed", true);
            }
        }
    }
}
