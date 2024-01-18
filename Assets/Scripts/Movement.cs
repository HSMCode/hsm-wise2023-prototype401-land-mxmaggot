using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody _rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            _rb.velocity = new Vector3(0, 0, 0);
        }
        else
        {
            _rb.AddForce(0, 0, speed, ForceMode.Force);
        }
    }
}
