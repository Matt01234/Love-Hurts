using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char2CollisionAttack : MonoBehaviour
{
    public bool isColliding;
    private Animator Animation;
    void Start()
    {
        isColliding = false;
        Animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    // OnCollisionEnter2D called when 2 hit boxes collide
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Char1_Hurtbox")
        {
            isColliding = true; // collision with opponent hurtbox true
        }
    }
    // OnCollisionExit2D called when 2 hit boxes finish colliding
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Char1_Hurtbox")
        {
            
            isColliding = false; // collision with opponent hurtbox false
        }
    }
}
       
