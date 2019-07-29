using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;
    public float upwardsForce = 600f;


    //FixedUpdate needs to be used when accessing Unity Physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //Move the Player left 
		if(Input.GetKey("d")) {
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

        //Move the Player right
		if(Input.GetKey("a")){
			rb.AddForce(-sidewaysForce *Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

        //Player Jump
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, upwardsForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        //Check to see if the player is below the ground plane and kill the player if so
		if(rb.position.y < -1f){
			FindObjectOfType<GameManager>().EndGame();
		}

    }
}
