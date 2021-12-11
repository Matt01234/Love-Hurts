using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 30f;
    public Text countDownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;    
    }

    // Update is called once per frame
    void Update()
    {
        //counts down by 1 second
        currentTime -= 1 * Time.deltaTime;
        countDownText.text = currentTime.ToString();
        // if time runs out nobody wins
        if(currentTime <= 0){
            SceneManager.LoadScene("Leaderboard3");    
        }
    }
}
