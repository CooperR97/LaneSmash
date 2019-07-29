﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;

    public Rigidbody rb;

	public float restartDelay = 1f;

	public GameObject completeLevelUI;

	public void CompleteLevel(){
		Debug.Log("Level won!");
		completeLevelUI.SetActive(true);
	}
    
	public void EndGame(){

		if(gameHasEnded == false){
			gameHasEnded = true;
			Debug.Log("Game Over.");
			Invoke("Restart", restartDelay);
            rb.freezeRotation = false;

		}

	}

	void Restart(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
