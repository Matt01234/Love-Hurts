using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    public static GameManagement manager;
    public float volume;
    public AudioSource audio;
   
    void Awake()
    {
        volume = 0.5f;
        Application.targetFrameRate = 60;
        // keeps this script alive in every scene
        if(manager == null){
            manager = this;
            DontDestroyOnLoad(this);
        }
        else if(manager != this){
            Destroy(gameObject);
        }
        
    }
    
   // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        // plays audio at volume level
        audio.volume = volume;
    }
    // the PlayButtonSound plays the select audio sound
    public void PlayButtonSound(){
        audio.Play();
    }
    
    
}