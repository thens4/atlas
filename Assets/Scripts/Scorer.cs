using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "hit")
        {
            score++;
            Debug.Log("You bumped " + score + " times ");
            
        }
    }
}
