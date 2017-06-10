	#pragma strict

	/*
	function Start () {
		
	}

	function Update () {
		
	}

	function Continue(){
	    
	}

	function Options(){
	    
	}

	*/
	function MenuPrincipal(){
		Application.LoadLevel("Menu");
	}

	function IniciarJogo(){
		Application.LoadLevel("_Complete-Game"); 
	}

	function Creditos(){
		Application.LoadLevel("Creditos");
	}

	function Sair(){
		Application.Quit();
	}
