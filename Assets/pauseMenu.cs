using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
	
	public static bool Pausedchecker = false;
	
	public GameObject pausedUI;
	
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
			if(Pausedchecker){
				resuming();
			}
			else{
				paused();
			}
		}
    }
	
	public void paused(){
		pausedUI.SetActive(true);
		Time.timeScale = 0f;
		Pausedchecker = true;
	}
	
	public void resuming(){
		pausedUI.SetActive(false);
		Time.timeScale = 1f;
		Pausedchecker = false;
		
	}
	
	public void saving(){
		Debug.Log("saving game");
		
	}
	
	public void loading(){
		Debug.Log("loading game");
		
	}
	
	public void mainmenu(){
		SceneManager.LoadScene(0);
		
	}
	
	public void quit(){
		Application.Quit();
	}
	
}
