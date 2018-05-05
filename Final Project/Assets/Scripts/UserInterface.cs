using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInterface : MonoBehaviour 
{
	[Header("Buttons")]
	public GameObject buttonPlay;
	public GameObject buttonHelp;
	public GameObject pauseButton;
	[Header("Panel and Tittle")]
	public GameObject panel;
	public GameObject tittle;
	
	private void Update () 
	{
		
	}

	public void PlayMode()
	{
		
		panel.SetActive(false);
		tittle.SetActive(false);
	}
}
