using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeRoom : MonoBehaviour {

	public GameObject door;
<<<<<<< HEAD
	public string password;
=======

>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
	[HeaderAttribute("Puzzles")]
	public GameObject first_puzzle;
	public GameObject second_puzzle;
	public GameObject third_puzzle;
	public GameObject fourth_puzzle;
	public GameObject fifth_puzzle;

	[HeaderAttribute("Lights")]
	public Light firstLight;
	public Light secondLight;
	public Light thirdLight;
	public Light fourthLight;
	public Light fifthLight;

	public int time;

	private Challenge p1;
	private Challenge p2;
	private Challenge p3;
	private Challenge p4;
	private Challenge p5;

	public int completed = 0;
	private float doorAngle = 360;
	// Use this for initialization
	void Start () {
<<<<<<< HEAD
		password = "";
=======
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
		if (first_puzzle != null) {
			first_puzzle.SetActive (true);
			p1 = first_puzzle.GetComponent<Challenge> ();
			p1.SetLight (firstLight);
<<<<<<< HEAD
			p1.number = 1;
=======
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
		}

		if (second_puzzle != null) {
			second_puzzle.SetActive (true);
			p2 = second_puzzle.GetComponent<Challenge>();
			p2.SetLight (secondLight);
<<<<<<< HEAD
			p2.number = 2;
=======
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
		}

		if (third_puzzle != null) {
			third_puzzle.SetActive (true);
			p3 = third_puzzle.GetComponent<Challenge> ();
			p3.SetLight (thirdLight);
<<<<<<< HEAD
			p3.number = 3;
=======
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
		}

		if (fourth_puzzle != null) {
			fourth_puzzle.SetActive (true);
			p4 = fourth_puzzle.GetComponent<Challenge> ();
			p4.SetLight (fourthLight);
<<<<<<< HEAD
			p4.number = 4;
=======
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
		}

		if (fifth_puzzle != null) {
			fifth_puzzle.SetActive (true);
			p5 = first_puzzle.GetComponent<Challenge> ();
			p5.SetLight (fifthLight);
<<<<<<< HEAD
			p5.number = 5;
=======
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
		}
	}
	// Update is called once per frame
	void Update () {
		if (completed == 5) {
			if (doorAngle > 270) {
				doorAngle -= 0.5f;
				Vector3 euler = door.transform.localEulerAngles;
				euler.z = doorAngle;
				door.transform.localEulerAngles = euler;
			}
		}
	}
}
