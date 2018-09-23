using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseScript : MonoBehaviour {

	public GameObject pauseMenu;
	public void Pause (){
		
		Time.timeScale = 0f;
		pauseMenu.SetActive (true);


	}

	public void Restart (){
		Time.timeScale = 1f;
		SceneManager.LoadScene (1);

	}

	public void MainMenu (){
		SceneManager.LoadScene (0);
	}

	public void ResumeGame (){

		Time.timeScale = 1f;
		pauseMenu.SetActive (false);
		

	}



}