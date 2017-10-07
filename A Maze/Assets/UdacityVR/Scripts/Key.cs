using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoof;
	public Door door;

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
		Instantiate(keyPoof, transform.position, Quaternion.Euler (-90.0f, 0, 0));

        // Make sure the poof animates vertically
        
		/*
		 * I think these two calls could be grouped, for example just call setKeyCollected here and inside setKey... call Unlock 
		*/
		// Call the Unlock() method on the Door
		door.Unlock();
        
		// Set the Key Collected Variable to true
		door.setKeyCollected(true);


        // Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(gameObject);
    }

}
