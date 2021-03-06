using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
	
	

	public bool isGrounded = false;
	public float thrust = 1.0f;

	//speed vars
	public float baseSpeed = .35f;
	public float groundSpeed;
	public float airSpeed;

	public float speed = 1.0f;
	private Rigidbody2D rb2D;


    // Start is called before the first frame update
    void Awake()
    {
			groundSpeed = .4f * this.baseSpeed;
			airSpeed = .1f * this.baseSpeed;
		//Gain Access to the rigidbody
		rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		if(this.transform.position.y < -50){
			SceneManager.LoadScene("1");
			
		}
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
		if(c.gameObject.CompareTag("ground") && rb2D.velocity.y ==0){
			this.speed = this.groundSpeed;
			//isGrounded = True
			isGrounded = true;
		}
  }

	public void resetHSpeed()
	{
		this.speed = this.groundSpeed;
	}


}
