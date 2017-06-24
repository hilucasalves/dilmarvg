using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Completed
{
public class Pause : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Time.timeScale = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.P)) {
				if (Time.timeScale == 1f) Time.timeScale = 0f;
				else Time.timeScale = 1f;
		}	
	}
}
}