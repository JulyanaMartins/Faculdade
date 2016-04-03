//--------------------------------//
//        Faculdade  Fucapi       //
//         Curso de Design        //
//  Design de Jogos - 5o Período  //
//--------------------------------//

// Professor: Sylker Teles

using UnityEngine;

using System.Collections;

// É preciso acrescentar essa linha 
// para importar a biblioteca Gerenic.
using System.Collections.Generic; 

public class Cartas : MonoBehaviour { // Nossa classe "Cartas"

	public SpriteRenderer slot; // O objeto que receberá e exibirá a imagem

	public List<Sprite> cartas = new List<Sprite>(); // As imagens no formato Sprite

	int cartaAtual; // cartaAtual armazenará o índice da carta atual exibida

	bool navegando; // Evitará que Navega seja disparada várias vezes.

	// Start executa sempre no início do game
	void Start () {

		navegando = false;
	
		int random = Random.Range (0, cartas.Count); // Sorteamos um número aleatório

		slot.sprite = cartas[random]; // Colocamos uma imagem aleatória no renderer

		cartaAtual = random; // Armazenamos o índice da carta atual 

	}
	
	// Update executa uma vez por quadro, ou seja, muitas ;P
	void Update () {

		if (navegando) return; // Se estivermos navegando entre as cartas, aborta.

		if (Input.GetKey(KeyCode.RightArrow)){ // Se o usuário pressionar a Seta Direita >>>

			navegando = true; // Vamos evitar que outra navegação comece

			cartaAtual += 1; // Aumentamos o valor de cartaAtual para a próxima carta.

			if (cartaAtual >= cartas.Count) // Se for a última carta

				cartaAtual = 0; // Vai pro início da lista

			StartCoroutine (Navega()); // Dispara a co-rotina Navega()

		}

		// Repetimos tudo para a Seta Esquerda:
		if (Input.GetKey(KeyCode.LeftArrow)){

			navegando = true;

			cartaAtual -= 1; // Diminuimos no lugar de aumentar, para a carta anterior

			if (cartaAtual < 0) // Se for a primeira carta

				cartaAtual = cartas.Count-1; // Volta pro final da lista

			StartCoroutine (Navega());

		}
	
	}


	// Navega carrega a próxima carta e agurda um pouco para evitar
	//  uma navegação muito rápida

	IEnumerator Navega () {

		slot.sprite = cartas[cartaAtual]; // Colocamos a imagem no renderer

		yield return new WaitForSeconds (0.2f); // Aguardamos uma fração de segundos

		navegando = false; // Desligamos navegando para que o usuário possa continuar

	}
}
