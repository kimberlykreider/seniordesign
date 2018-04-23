using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge : MonoBehaviour {

	public bool completed = false;
<<<<<<< HEAD
	public int number;
=======
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
	public EscapeRoom room;
	public Light completedLight;
	// Use this for initialization
	public virtual void Start () {
		
	}
	public void SetLight(Light l) {
		completedLight = l;
<<<<<<< HEAD
	}

	public virtual void Completed() {
		room.password += this.number;
		
		switch (room.completed) {
		case 0:
			completedLight.color = Color.red;
			break;
		case 1:
			Color color = new Color (1, 0.65F, 0);
			completedLight.color = color;
			break;
		case 2:
			completedLight.color = Color.yellow;
			break;
		case 3:
			completedLight.color = Color.green;
			break;
		case 4:
			completedLight.color = Color.blue;
			break;
		}
		room.completed++;
		print("completed light activate");
		completed = true;
		completedLight.enabled = true;
=======
		print ("completed light activated");
	}

	public void Completed() {
		//room.completed++;
		completed = true;
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
	}

	// Update is called once per frame
	void Update () {
		if (completed) {
			completedLight.enabled = true;
		}
	}
}
