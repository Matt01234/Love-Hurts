using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C1Grounded : MonoBehaviour
{
    private Animator Animation;

    void Start()
    {
        Animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // checks if this box collider is colliding with ground box collider
        if(collision.collider.tag == "Ground"){
            this.GetComponent<C1Movements>().isGrounded = true; // sets grounded to true in other script so player can jump 
            Animation.SetBool("Jump", false);

        }
    }
    
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground"){
            this.GetComponent<C1Movements>().isGrounded = false; // sets grounded to false in other script to avoid infinite jumps 
            Animation.SetBool("Jump", true);

        }
    }
}
