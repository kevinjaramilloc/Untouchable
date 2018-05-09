using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInterface : MonoBehaviour 
{
	[Header("Buttons")]
	public GameObject playButton;
	public GameObject helpButton;
	public GameObject backButton;
	public GameObject creditsButton;
	[Header("Panel and Tittle")]
	public GameObject panel;
	public GameObject tittle;
	public GameObject highConcept;
	[Header("Information")]
	public GameObject credits;
	public GameObject instructions;
	

	public void MainUI()
	{
		tittle.SetActive(true);
		highConcept.SetActive(true);
		helpButton.SetActive(true);
		playButton.SetActive(true);
		creditsButton.SetActive(true);
		credits.SetActive(false);
		instructions.SetActive(false);
		backButton.SetActive(false);
	}

	public void PlayMode()
	{
		panel.SetActive(false);
		tittle.SetActive(false);
		highConcept.SetActive(false);
		helpButton.SetActive(false);
		playButton.SetActive(false);
		creditsButton.SetActive(false);
		credits.SetActive(false);
		instructions.SetActive(false);
	}

	public void Instructions()
	{
		instructions.SetActive(true);
		backButton.SetActive(true);
		tittle.SetActive(false);
		highConcept.SetActive(false);
		helpButton.SetActive(false);
		playButton.SetActive(false);
		creditsButton.SetActive(false);
		credits.SetActive(false);
	}

	public void Credits()
	{
		credits.SetActive(true);
		backButton.SetActive(true);
		tittle.SetActive(false);
		highConcept.SetActive(false);
		helpButton.SetActive(false);
		playButton.SetActive(false);
		creditsButton.SetActive(false);
		instructions.SetActive(false);
	}
}
