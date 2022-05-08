using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	
	public bool isGrounded = false;
	public float thrust = 1.0f; 

	private Rigidbody2D rb2D;	
	
	
    // Start is called before the first frame update
    void Awake()
    {
		//Gain Access to the rigidbody
		rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		
		
        //Static Jumping
		//On Space Bar Pressed
		if(Input.GetKeyDown(KeyCode.Space)){
			//If isGrounded
			if(isGrounded){
				rb2D.AddForce(transform.up * thrust);
			}
		}
		
				
		//Left Movement
		
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
		if(c.gameObject.tag == "ground"){
			//isGrounded = True 
			isGrounded = true; 
		}
    }
			
			

}
