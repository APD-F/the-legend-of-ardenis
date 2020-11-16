using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Main : MonoBehaviour
{

	public void dosomething(){
		Debug.Log("working");
	}
	
	public void playGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	
	
    //Quits game
	public void quitGame()
	{
		//sends debugging message to confirm working
		Debug.Log("QUIT");
		//UnitEditor.EditorApplication.isPlaying = false;
		Application.Quit();
	}
}
