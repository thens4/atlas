using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            //Debug.Log("Bumped.");  
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "hit";
        }
        
        
    }
}
