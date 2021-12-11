using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C1Health : MonoBehaviour
{
    public GameObject healthBar;
    public int health;
    public BoxCollider2D hurtBox, opponentHitBox;
    public Char1CollisionAttack c1attack;
    public Char2CollisionAttack c2attack;
    
    void Start()
    {
        float h = (float)health / 100.0f;
        healthBar.GetComponent<HealthBar>().SetHealth(h);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(c2attack.isColliding == true)
        {
            // converts health from 0 - 100 to 0 - 1 for the slider value 
            float h = (float)health / 100.0f;
            h -= 0.05f;
            healthBar.GetComponent<HealthBar>().SetHealth(h);
            Debug.Log(h * 100);
            health = (int)(h * 100);
           
        }

    }

}
