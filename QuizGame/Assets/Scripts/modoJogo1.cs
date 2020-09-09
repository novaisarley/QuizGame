using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class modoJogo1 : MonoBehaviour {

	public Text txtNomeExercicio;
	public Text txtPergunta;
	public Text txtInfoPergunta;

	public GameObject barraTempo;
	public GameObject barraProgresso;

	public Button[] botoes;
	public string[] perguntas;
	public string[] alternativaCorreta;

	//----------------------------------------

	private int idPergunta = 0; 
	private int totalPerguntas;
	private int qtdRespondidas = 0;
	private int qtdAcertos = 0, qtdErros = 0;


	// Use this for initialization
	void Start () {
		montarListaPerguntas ();
		barraProgresso.transform.localScale = new Vector3 (0, 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void montarListaPerguntas(){
		if (perguntas.Length > idPergunta) {
			txtPergunta.text = perguntas [idPergunta];
			totalPerguntas = perguntas.Length;
			txtInfoPergunta.text = "Pergunta " + (idPergunta + 1).ToString() + " de " + (totalPerguntas).ToString();
		}

	}

	public void verificarAlternativa(string alternativa){
		if(idPergunta < perguntas.Length){
			if(alternativa == alternativaCorreta[idPergunta]){
				qtdAcertos++;
			}
			else{
				qtdErros++;
			}
			qtdRespondidas++;
			barraProgresso.transform.localScale = new Vector3 (qtdRespondidas/(float)(totalPerguntas), 1, 1);
			proximaQuestao ();
		}
	}

	public void proximaQuestao(){
		idPergunta++;
		if (idPergunta < perguntas.Length) {
			txtPergunta.text = perguntas [idPergunta];
			txtInfoPergunta.text = "Pergunta " + (idPergunta + 1).ToString() + " de " + (totalPerguntas).ToString();
		}else{
			//finalizarTeste();
			Debug.Log("Finalizar Teste");
			Debug.Log("Questoes acertadas: " + qtdAcertos);
		}
	}
}
