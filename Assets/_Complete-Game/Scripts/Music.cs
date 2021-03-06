﻿using UnityEngine;
using System.Collections;

namespace Completed
{
public class Music : MonoBehaviour {

	public Texture2D musicOn; 
	public Texture2D musicOff; 
	public bool ativo;

	public static Music instance = null;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (ativo) {
			SoundManager.instance.musicSource.mute = false;
			GetComponent<GUITexture>().texture = musicOn;
		} else {
			SoundManager.instance.musicSource.mute = true;
			GetComponent<GUITexture>().texture = musicOff;
		}
	}

	public void OnMouseDown() {
		ativo = !ativo;
	}

	}
}