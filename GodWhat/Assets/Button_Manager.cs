using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Button_Manager : MonoBehaviour {

	public void playBtn(string play)
	{
		SceneManager.LoadScene (play);
	}

	public void quitBtn()
	{
		Application.Quit ();
	}
}
