using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour {

	public PlayerMovement movement;

    public gun gun;
	
	void OnCollisionEnter (Collision collisionInfo) {
		
		if(collisionInfo.collider.tag == "Obstacle"){
			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}

        if(collisionInfo.collider.tag == "PowerUp")
        {
            gun.enabled = true;
        }

	}
}
