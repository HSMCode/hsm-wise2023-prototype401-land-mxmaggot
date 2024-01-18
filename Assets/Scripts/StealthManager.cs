using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StealthManager : MonoBehaviour
{
    public float CatTimer = 10;
    private bool isHiding;
    public Animator catAnimator;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CatTimer -= Time.deltaTime;
        if (CatTimer <= 0 )
        {
            catAnimator.SetBool("catAttack", true);
            if (isHiding == false)
            {
                Destroy(this);
                Debug.Log("YOU ARE DEAD");
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Hiding"))
        {
            Debug.Log("Hiding");
            isHiding = true;
        }
    }
}
