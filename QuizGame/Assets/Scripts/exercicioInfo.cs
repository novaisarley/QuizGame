using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exercicioInfo : MonoBehaviour {

	public int idExercicio;
	public string nomeExercicio;
	public int minPontos1Estrela;
	public int minPontos2Estrelas;

	public Text txtIdExercicio;
	public GameObject[] estrelas;


	// Use this for initialization
	void Start () {
		txtIdExercicio.text = idExercicio.ToString();
		preencherEstrelas ();
	}

	void preencherEstrelas(){

		int nEstrelas = 0;

		foreach (GameObject e in estrelas) {
			e.SetActive (false);
		}
		
	}
}
