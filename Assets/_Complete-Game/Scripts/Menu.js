#pragma strict

function Start () {
	
}

function Update () {
	
}
function MenuPrincipal()
{
	Application.LoadLevel("Menu");
}

function IniciarJogo()
{
	Application.LoadLevel("_Complete-Game");
}
//function Continue()
//{
    
//}
function Creditos()
{
    Application.LoadLevel("creditos");
}
//function Options()
//{
    
//}
function Sair()
{
  Application.Quit();

}
