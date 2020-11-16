using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class volset : MonoBehaviour
{
	
	public AudioMixer audiomix;
	
	
	
    public void volume(float vol){
		//Debug.Log(vol);
		audiomix.SetFloat("volcon", vol);
	}
	
	

}
