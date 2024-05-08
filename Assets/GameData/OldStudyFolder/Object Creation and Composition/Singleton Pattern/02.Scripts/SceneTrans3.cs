using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrans3 : MonoBehaviour {

	// 기본적으로는 화면에는 한개의 Scene이 로드되고,
	// 다른 Scene을 다시 로드하는 방식으로 Scene을 교체한다.
	// 기존 Scene에 Scene을 추가할 수도 있는데, 이것을 Additive Loading이라고 한다. 
	// Additive Scene은 예를 들면 말풍선 모양으로 상상하는 씬(?) 같은 느낌이다.

	public void AddScene () {
		// 새로운 씬을 현재 씬에 추가적으로 로드 (Single은 기존 씬 close.)
		SceneManager.LoadScene("06-Scene3-2", LoadSceneMode.Additive);
	}

	public void RemoveScene () {
		// 현재 활성화된 씬을 unload해라.
		SceneManager.UnloadSceneAsync("06-Scene3-2");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

}
