using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerClass : MonoBehaviour {

	bool gameHasEnd = false;
	bool winGame = false;

	public void EndGame() {
		if (gameHasEnd == false) {
			gameHasEnd = true;
			Debug.Log ("Game Over");
			SceneManager.LoadScene("GameOver");
		}
	}

	public void WinTheGame() {
		if (winGame == false) {
			winGame = true;
			SceneManager.LoadScene ("Win");
		}
	}

}
