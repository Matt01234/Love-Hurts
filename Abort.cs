using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Abort : MonoBehaviour
{
    public float abortTime;
    public float remainingTime;
    // Start is called before the first frame update
    void Start()
    {
        remainingTime = abortTime;
    }

    // Update is called once per frame
    void Update()
    {
        // if any key is pressed reset the remainingTime
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.N) || Input.GetKeyDown(KeyCode.M)){
            remainingTime = abortTime;
        } 
        // count down
        if(remainingTime > 0){
            remainingTime -= Time.deltaTime;
        }
        // when nobody interacts with the game the title screen will be loaded
        else{
            SceneManager.LoadScene("Title");    
        }
    }
    
}
