using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Completed
{
public class Pause : MonoBehaviour {

		public GameObject menu;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1f;
			menu.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
			if (Input.GetKeyDown (KeyCode.P)) {
				if (Time.timeScale == 1f) {
					SoundManager.instance.musicSource.Pause ();
					menu.SetActive (true);
					Time.timeScale = 0f;
				} else {
					SoundManager.instance.musicSource.Play();
					menu.SetActive (false);
					Time.timeScale = 1f;
				}
					
			}
			if (Input.GetKeyDown (KeyCode.Q)) {
				SoundManager.instance.musicSource.Stop();
				GameManager.instance.StartCoroutine("wait");
				Destroy(GameManager.instance);
				SceneManager.LoadScene("Menu");
			}
	}
}
}