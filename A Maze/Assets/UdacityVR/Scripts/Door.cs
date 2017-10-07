using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	public AudioClip clickOnDoorLocked;
	public AudioClip clickOnDoorUnlocked;

	private AudioSource audioSource;

	// Create a boolean value called "locked" that can be checked in OnDoorClicked()
	private bool locked;
    // Create a boolean value called "opening" that can be checked in Update()
	private bool opening;
	private bool keyCollected;

	void Start()
	{
		locked = true;
		opening = false;
		keyCollected = false;

		audioSource = GetComponent<AudioSource>();
	}

    void Update() 
	{
        // If the door is opening and it is not fully raised
		if(opening)
		{
			// Animate the door raising up (see treasure)
		
		}
            
    }

    public void OnDoorClicked() 
	{
        // If the door is clicked and unlocked
		if(!locked)
		{
			// Set the "opening" boolean to true
			opening = true;
			audioSource.clip = clickOnDoorUnlocked;
			audioSource.Play ();

			Debug.Log ("click on door unlocked");
		}   
        // (optionally) Else
		else{
			// Play a sound to indicate the door is locked
			audioSource.clip = clickOnDoorLocked;
			audioSource.Play ();

			Debug.Log ("click on door locked");
		}

    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
		locked = false;
    }

	public bool isLocked()
	{
		return locked;
	}

	public bool isKeyCollected()
	{
		return keyCollected;
	}

	public void setKeyCollected(bool collected)
	{
		keyCollected = collected;
	}
}
