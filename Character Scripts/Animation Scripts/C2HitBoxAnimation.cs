using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C2HitBoxAnimation : MonoBehaviour
{
    private Animator Animation;
    public bool isAttacking;
    private float timer;
    private bool hasAttacked;
    private float hasAttackedTime;
    private bool hasAltAttacked;
    private float hasAltAttackedTime;
    public AudioSource attackSound, altAttackSound;
    
    void Start()
    {
        Animation = GetComponent<Animator>();
        isAttacking = false;
        hasAttacked = false;
        hasAltAttacked = false;
    }

    // Update is called once per frame
    void Update()
    {
        AttackAnimation();
        AltAttackAnimation();
        // prevents spamming keys
        if(timer <= 0)
        {
            isAttacking = false;
        }
        timer -= 1 * Time.deltaTime;
        
        if(hasAttackedTime <= 0)
        {
            hasAttacked = false;
        }
        hasAttackedTime -= 1 * Time.deltaTime;
        
        if(hasAltAttackedTime <= 0)
        {
            hasAltAttacked = false;
        }
        hasAltAttackedTime -= 1* Time.deltaTime;
        
   
    }
    // AttackAnimation function plays the first attack animation
    public void AttackAnimation() 
    {
        if (this.name == "Char2")
        {
            if (Input.GetButtonDown(this.name + "_Fire1") && hasAttacked == false)
            {
                attackSound.Play();
                isAttacking = true;
                timer = 0.5f;
                Animation.SetTrigger("SharkAttack1");
                hasAttackedTime = 0.5f;
                hasAttacked = true;
            }
        }
    }
    // AltAttackAnimation function plays the special attack animation
    public void AltAttackAnimation() 
    {
        if (this.name == "Char2")
        {       
            if (Input.GetButtonDown(this.name + "_Fire2") && hasAltAttacked == false)
            {                    
                altAttackSound.Play();
                timer = 0.5f;
                isAttacking = true;
                Animation.SetTrigger("SharkAttack2");
                hasAltAttacked = true;
                hasAltAttackedTime = 2f;
            }     
        }
    }
}