using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public GameManagement gm; // GameManagement script has access to the PlayButtonSound function

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManagement>();
        //Debug.Log("audio here: " + gm);
        
    }

    // Update is called once per frame
    void Update()
    {
        // I is the special button underneath the arcade cabinet to open settings
        if(Input.GetKeyDown(KeyCode.I)){
            SceneManager.LoadScene("settings");    
        }        
    }
    // LoadScene function loads a specific scene
    // @param name passes the scene name argument
    public void LoadScene(string name)
    { 
        gm.PlayButtonSound();
        SceneManager.LoadScene(name);
    }
     
}
