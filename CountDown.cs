using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    // Start is called before the first frame update
    public Image three, two, one, go;
    
    void Start()
    {
        // starts by showing the number 3 sprite
        three.enabled = true;
        two.enabled = false;
        one.enabled = false;
        go.enabled = false;  
        StartCoroutine(Count());  
    }

    IEnumerator Count()
    {
        // switches between 3, 2, 1, go sprites
        yield return new WaitForSeconds(1);
        
        three.enabled = false;
        two.enabled = true;
    
        yield return new WaitForSeconds(1);
     
        two.enabled = false;
        one.enabled = true;
      
        yield return new WaitForSeconds(1); 
        
        one.enabled = false;
        go.enabled = true;
        
        yield return new WaitForSeconds(1);
    
        go.enabled = false;
        
    }
}
