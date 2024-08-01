using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]float timeToWait = 10;
    MeshRenderer renderer;
    Rigidbody rb;
    
    private void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        renderer.enabled = false;
    }

    void Update()
    {
        //Debug.Log(Time.time);
        if (Time.time >= timeToWait)
        {
            
           // Debug.Log(timeToWait+" seconds has elapsed. ");
            
            renderer.enabled = true;
           
            
            rb.useGravity = true;
        }
    }

    
}
