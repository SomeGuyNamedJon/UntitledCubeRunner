using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public AudioSource sfx;
    public AudioClip jumpFX;

    public PowerUpController powerUp;

	public Rigidbody rb;
    public float moveForce;
    public float jumpForce = 7f;
    public bool moveLeft;
    public bool moveRight;

    public bool jump;
    public bool isGrounded;
    public bool jumpCharge;
	
    private void OnCollisionEnter(Collision collision) {
        if(collision.collider.tag == "Ground"){
            isGrounded = true;
            jumpCharge = true;
            Debug.Log("Jump charged");
        }
    }

    private void OnCollisionStay(Collision collision) {
        if(collision.collider.tag == "Ground"){
            isGrounded = true;
            jumpCharge = true;
            Debug.Log("Jump charged");
        }
    }

    private void OnCollisionExit(Collision collision) {
        if(collision.collider.tag == "Ground"){
            isGrounded = false;
        }
    }

    // Update is called once per frame
    void Update(){

        moveLeft = false;
        moveRight = false;
        jump = false;

        if(Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow)){
            moveRight = true;
        }
        if(Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow)){
            moveLeft = true;
        }
        if(Input.GetKey(KeyCode.Space)){
            jump = true;
        }

        if(jump && isGrounded){
            sfx.PlayOneShot(jumpFX, .50f);
            rb.AddForce(0,jumpForce,0, ForceMode.VelocityChange);
        }
        if(powerUp.doubleJump && !isGrounded){
            if(jumpCharge && Input.GetKeyDown(KeyCode.Space)){
                sfx.PlayOneShot(jumpFX, .50f);
                rb.AddForce(0,jumpForce*5,0, ForceMode.Impulse);
                jumpCharge = false;
            }
        }
    }

    
    void FixedUpdate(){
        if(moveRight){
            rb.AddForce(moveForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if(moveLeft){
            rb.AddForce(-moveForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if(powerUp.doubleJump){
            powerUp.jumpPowerUpTime -= Time.deltaTime;
            if(powerUp.jumpPowerUpTime <= 0){
                powerUp.doubleJump = false;
                powerUp.jumpPowerUpTime = 5;
            }
        }
    }

}
