using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class Mover : MonoBehaviour
{
    //[SerializeField] float xValue = 0f;
    //[SerializeField] float yValue = 0f;
    //[SerializeField] float zValue = 0f;

    [SerializeField] float moveSpeed = 10f;
    float score=0;
    
    void Start()
    {
        transform.Translate(0,0,0);
        PrintInstruction();
    }

    
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {

        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0, zValue);
    }



    void PrintInstruction()
    {
        Debug.Log("Welcome to my game.");
        Debug.Log("Move your player with W,A,S,D");
        Debug.Log("Don't hit the walls.");
    }

    
}
