using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    public Slider slider;
    public GameManagement gm;
    
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManagement>();
    }

    // Update is called once per frame
    void Update()
    {
        // volume variable in the GameManagment script equals what the slider is set to 
        gm.volume = slider.value;
    }
    
    
}
