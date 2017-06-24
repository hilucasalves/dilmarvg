using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
	/*
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	*/

	public void MenuPrincipal(){
		SceneManager.LoadScene("Menu");
	}

	public void IniciarJogo(){
		SceneManager.LoadScene("_Complete-Game");
	}

	public void Creditos(){
		SceneManager.LoadScene("Creditos");
	}

	public void Sair(){
		Application.Quit();
	}
}
