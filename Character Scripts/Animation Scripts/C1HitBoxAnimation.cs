using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C1HitBoxAnimation : MonoBehaviour
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
        if (this.name == "Char1")
        {
            if (Input.GetButtonDown(this.name + "_Fire1") && hasAttacked == false)
            {
                attackSound.Play();
                isAttacking = true;
                hasAttackedTime = 0.5f;
                timer = 0.5f;
                Animation.SetTrigger("CatAttack1");
                hasAttacked = true;

            }
           
        }
    }
    // AltAttackAnimation function plays the special attack animation
    public void AltAttackAnimation() 
    {
        if (this.name == "Char1")
        {
            if (Input.GetButtonDown(this.name + "_Fire2") && hasAltAttacked == false)
            {
                altAttackSound.Play();
                isAttacking = true;
                timer = 0.5f;
                Animation.SetTrigger("CatAttack2");
                hasAltAttacked = true;
                hasAltAttackedTime = 2f;
            }
            
        }
    }
}
    