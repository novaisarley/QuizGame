using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btnComands : MonoBehaviour {

	public void irParaCena(string nomeCena){
		SceneManager.LoadScene (nomeCena);
		//SceneManager.LoadScene(nomeCena, LoadSceneMode.Additive);
	}

	public void finish(){
		Application.Quit ();
	}
}
