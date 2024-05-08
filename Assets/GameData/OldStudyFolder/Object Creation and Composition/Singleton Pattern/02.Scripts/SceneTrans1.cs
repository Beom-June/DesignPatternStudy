using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneTrans1 : MonoBehaviour {

	public void SceneTrans1_1 () {
		SceneManager.LoadScene("01-Scene1-1");
	}
	
	public void SceneTrans1_2 () {
		SceneManager.LoadScene("02-Scene1-2");
	}

}
