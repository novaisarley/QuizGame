using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exercicioInfo : MonoBehaviour {

	private exercicioScene exercicioScene;

	public int idExercicio;
	public string nomeExercicio;
	public int minPontos1Estrela;
	public int minPontos2Estrelas;
	public int pontuacao;

	public Text txtIdExercicio;
	public GameObject[] estrelas;


	// Use this for initialization
	void Start () {
		exercicioScene = FindObjectOfType (typeof(exercicioScene)) as exercicioScene;

		txtIdExercicio.text = idExercicio.ToString();
		preencherEstrelas ();
	}

	void preencherEstrelas(){

		int nEstrelas = 0;

		foreach (GameObject e in estrelas) {
			e.SetActive (false);
		}

		if (pontuacao == 10) {nEstrelas = 3;}
		else if(pontuacao >= minPontos2Estrelas) {nEstrelas = 2;}
		else if(pontuacao >= minPontos1Estrela) {nEstrelas = 1;}

		for (int i = 0; i < nEstrelas; i++) {
			estrelas [i].SetActive (true);
		}
		
	}

	public void selecionaExercicio(){
		exercicioScene.txtNomeExercicio.text = nomeExercicio;
	}
}
