using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class countdownTimer : MonoBehaviour {

	float timeRemaining = 4;
	private GUIStyle guiStyle = new GUIStyle();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timeRemaining -= Time.deltaTime;
	}

	void OnGUI() {
		guiStyle.alignment = TextAnchor.MiddleCenter;
		guiStyle.fontSize = 200;
		if (timeRemaining > 0) {
			GUI.Label (new Rect (200, 200, 300, 300), "" + (int)timeRemaining, guiStyle);
		} else {
			GUI.Label (new Rect (250, 250, 300, 300), "GO", guiStyle);
			SceneManager.LoadScene ("_Complete-Game");
		}
	}
}
