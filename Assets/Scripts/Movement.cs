using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	
	public bool isGrounded = false; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
		
        //Static Jumping
		//On Space Bar Pressed
			//If isGrounded
				//Do Jump Command 
		
		
				
		//Left Movement
		
		//Right Movement
    }
	
	//On Collision Exit
		//If Collision Tag is Ground
			//isGrounded = false
			
	//On Collision Enter
	void OnCollisionEnter2D(Collision2D c) {
        //If Collision Tag is Ground
		if(c.gameObject.tag == "ground"){
			//isGrounded = True 
			isGrounded = true; 
		}
    }
			
			

}
