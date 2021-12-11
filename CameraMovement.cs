using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraMovement : MonoBehaviour
{
    public Camera cam;
    public GameObject char1, char2;
    public float x1, y1, x2, y2, midpoint;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {   
        UpdatePosition(); 
        
        midpoint = Calc();
        // determines whether the camera should zoom in or out 
        if(midpoint > 4f){
            cam.orthographicSize = 4;
        }
        else if(midpoint < 3){
            cam.orthographicSize = 3;
            
        }
        else{
            cam.orthographicSize = midpoint;
               
        }
        // determines whether the camera should move left or right
        if((x2 + x1)/2 < -4){
            cam.transform.position = new Vector3 (-4, cam.transform.position.y,  cam.transform.position.z);
        }
        else if((x2 + x1)/2 > 4){
            cam.transform.position = new Vector3 (4, cam.transform.position.y,  cam.transform.position.z);
        }
        else{
            cam.transform.position = new Vector3 ((x2 + x1)/2, cam.transform.position.y,  cam.transform.position.z); 
        }
        
    }
    // UpdatePosition function calcualtes the x and y position of each player and 
    // puts them in the corresponding variable
    private void UpdatePosition(){
        x1 = char1.transform.position.x;
        y1 = char1.transform.position.y;
        x2 = char2.transform.position.x;
        y2 = char2.transform.position.y;
    }
    // the Calc function calculates the midpoint 
    // @return the midpoint between the 2 players
    private float Calc(){
        double num1 = Math.Pow(x2 - x1, 2);
        double num2 = Math.Pow(y2 - y1, 2);
        return (float) Math.Sqrt(num1 + num2) / 2;
    }
}
