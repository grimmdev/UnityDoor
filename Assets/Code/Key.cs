using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour
{
	// Let's select our specific door that this key opens...
	public Door door;

	void Awake()
	{
		// We check to make sure our variable, door which we assign, isn't null. For logical reasons!
		if(door == null)
		{
			// LETS GET MAD ABOUT IT! YEAH! AND TELL SOMEONE! RAWR!
			Debug.Log("ASSIGN THE DARN DOOR!");
		}
	}

	// This is the method for detecting if the player can or has picked up the key.
	void OnTriggerStay (Collider other)
	{
		// If our specific key is pressed and the door is locked
		if(Input.GetKeyDown(KeyCode.E) && other.tag == "Player" && door.doorState == Door.DoorState.Locked)
		{
			// then we can logically unlocked our door.. SO LETS DO IT!
			door.doorState = Door.DoorState.Unlocked;
			this.gameObject.SetActive(false);
		}
	}
}
