using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C1Movements : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public bool isGrounded = false; // prevents infinite jumps
    private Animator Animation; 
    private bool go = false; // 3 2 1 go countdown
    public AudioSource jumpAudio, walkAudio;
    public C1HitBoxAnimation c1Attack;
    
    void Start()
    {
        StartCoroutine(Count()); 
        Animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        Jump();
        Crouch();
    }
    // Run function makes the player move left and right
    private void Run(){
        Vector3 movement = new Vector3(Input.GetAxis(this.name + "_Horizontal"), 0f, 0f); // Input axis has the players name 
        
        if(go == true && c1Attack.isAttacking == false){
    
            transform.position += movement * Time.deltaTime * moveSpeed;
        }
    }
    // Crouch function makes the player crouch
    private void Crouch()
    {
        if (Input.GetButtonDown(this.name + "_Crouch") && isGrounded == true && go == true && c1Attack.isAttacking == false)
        {
            Animation.SetBool("Crouch", true);

            //Debug.Log("Crouch");
        }
        else
        {
            Animation.SetBool("Crouch", false);
            
        }

    }
    // Jump function makes the player jump
    private void Jump(){
        Vector2 jump = new Vector2(0f, jumpForce);
        if(Input.GetButtonDown(this.name + "_Jump") && isGrounded == true && go == true && c1Attack.isAttacking == false){
            jumpAudio.Play();
            gameObject.GetComponent<Rigidbody2D>().AddForce(jump, ForceMode2D.Impulse);
            Animation.SetBool("Jump", true);
        }
        else
        {
            Animation.SetBool("Jump", false);
        }
    }
    
    IEnumerator Count()
    {
        //yield on a new YieldInstruction that waits for 4 seconds.
        yield return new WaitForSeconds(4);
        go = true;
    }
}