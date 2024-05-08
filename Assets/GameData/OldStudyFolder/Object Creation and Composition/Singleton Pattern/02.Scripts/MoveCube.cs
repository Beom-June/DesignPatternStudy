using UnityEngine;
using System.Collections;

public class MoveCube : MonoBehaviour {

	float speed = 20.0f;
	
	void Update () 
	{
		// 키보드 입력 
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		
		// 이동거리 보정
		h = h * speed * Time.deltaTime;
		v = v * speed * Time.deltaTime;
		
		// 실제 이동
		transform.Translate(Vector3.right * h);
		transform.Translate(Vector3.forward * v);	
	}
}
