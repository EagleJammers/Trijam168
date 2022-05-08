using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	
	public bool isGrounded = false;
	public float thrust = 1.0f; 
	
	//speed vars
	public float groundSpeed = .2f; 
	public float airSpeed = .1f; 
	
	public float speed = 1.0f;
	private Rigidbody2D rb2D;	
	
	
    // Start is called before the first frame update
    void Awake()
    {
		//Gain Access to the rigidbody
		rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		if(!this.isGrounded){
			if(this.speed > this.airSpeed){
				this.speed -= .002f; 
				
			}
			
		}
		//this.speed = (this.isGrounded) ? this.groundSpeed : this.airSpeed; 
        //Static Jumping
		//On Space Bar Pressed
		if(Input.GetAxisRaw("Jump") > 0){
			//If isGrounded
			if(isGrounded){
				isGrounded = false; 
				rb2D.AddForce(transform.up * thrust, ForceMode2D.Impulse);
			}
		}
	
		
			


			
		//Move left & right
		transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * speed, 0, 0)); 

		
		//Right Movement
    }
	
	//On Collision Exit
	void OnCollisionExit2D(Collision2D c){
		//If Collision Tag is Ground
		if(c.gameObject.tag == "ground"){
			isGrounded = false;
		}
	}
	//On Collision Enter
	void OnCollisionEnter2D(Collision2D c) {
		
        //If Collision Tag is Ground
		if(c.gameObject.CompareTag("ground")){
			this.speed = this.groundSpeed; 
			//isGrounded = True 
			isGrounded = true; 
		}
    }
			
			

}
