using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class sceneTimer : MonoBehaviour {

	public void  ModeSelect(){
		StartCoroutine("Wait");

	}

	IEnumerator Wait()
	{
		yield return new WaitForSeconds(3);
		SceneManager.LoadScene ("Menu");
	}
}
