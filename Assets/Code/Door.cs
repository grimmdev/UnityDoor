using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{
	// This enum holds our states of the door, first state is that the door is locked and etc...
	// Static means the door can never be opened under any conditions.
	// Locked means it requires something.. maybe a key?
	// Unlocked means.. well it's means the door can be opened now!
	// Open means that the door is opened already.
	public enum DoorState {
		Static, Locked, Unlocked, Open 
	};
	// now we make the public declaration of our state so the key can use it, then we apply a default of it starting locked.
	public DoorState doorState = DoorState.Locked;

	// Use this for initialization, which in this case is pointless?
	void Awake ()
	{
		// Only uncomment the lower line if you need to force it as Locked on start, for some reason of course!
		//doorState = DoorState.Locked;
		// Or to make it unlocked off the bat, uncomment the line below.
		//doorState = DoorState.Unlocked;
	}

	// This is the method for the door
	void OnTriggerStay (Collider other)
	{
		// Make sure they press the magic button and also that it IS the player...
		if(Input.GetKeyDown(KeyCode.E) && other.tag == "Player")
		{
			// Check which state the door is "in", this state means it's ready to open.
			if(doorState == DoorState.Unlocked)
			{
				// run our cool function!
				Open();
			}
			// While this state means it already IS open.
			else if(doorState == DoorState.Open)
			{
				Close();
			}
		}
	}

	// this function is responsible for handling what the door is suppose to do when it's opening.
	void Open()
	{
		// let the door know that it's open, by changing it's state.
		doorState = DoorState.Open;
		// I used an animator to make the door gameobject move
		this.GetComponent<Animator>().SetInteger("State",1);
	}

	// however.. this one is responsible for when the door is closing..
	void Close()
	{
		// now the door state is closed.. but not locked.
		doorState = DoorState.Unlocked;
		// more animator stuff!
		this.GetComponent<Animator>().SetInteger("State",0);
	}
}
