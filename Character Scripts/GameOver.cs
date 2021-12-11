using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public C1Health c1h;
    public C2Health c2h;
    public Timer t;
    public string GameWinner;
    
    void Start()
    {
        temptime = 5 ;
        GameWinner = "No Winner";
    }

    private float temptime;

    // Update is called once per frame
    void Update()
    {
        // load each leaderboard screen depending who won
        if (c1h.health <=0 || c2h.health <=0 || t.currentTime <= 0) 
        {

            if (c1h.health <= 0)
            {
                GameWinner = "Player 2 wins";
                SceneManager.LoadScene("Leaderboard");

            }
            if (c2h.health <= 0)
            {
                GameWinner = "Player 1 wins";
                SceneManager.LoadScene("Leaderboard2");
            }
            if (c1h.health == c2h.health || t.currentTime <= 0)
            {
                SceneManager.LoadScene("Leaderboard3");
            }
            temptime -= 1 * Time.deltaTime;
            
        }
    }
}
