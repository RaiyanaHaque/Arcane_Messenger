using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameOverScript : MonoBehaviour
{
	public Text scoreText;
    int score = 0;

    void Start()
    {
        score = PlayerPrefs.GetInt("Score");
    }

    void OnGUI()
    {

		scoreText.text = "Score:" + score.ToString ();
    }
}

