using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 대상
public class ConcreteSubject2 : MonoBehaviour {

	public GameObject sphere;
	public GameObject box1;
	public GameObject box2;
	public GameObject box3;

	delegate void NotiHandler(float rot);
	NotiHandler _notiHandler;
	float time;

	void Start()
	{
		Observer2 obj1 = box1.GetComponent<ConcreteObserver3>();
		Observer2 obj2 = box2.GetComponent<ConcreteObserver3>();
		Observer2 obj3 = box3.GetComponent<ConcreteObserver3>();

		_notiHandler += new NotiHandler(obj1.OnNotify);
		_notiHandler += new NotiHandler(obj2.OnNotify);
		_notiHandler += new NotiHandler(obj3.OnNotify);

		time = 2.0f;
	}

	public void MovePosition ()
	{
		// 업적 달성
		sphere.transform.position = new Vector3 (2, 0.5f, -3);

		_notiHandler(time);

		StartCoroutine(ResetPosition(time));
	}

	IEnumerator ResetPosition (float time)
	{
		yield return new WaitForSeconds(time);
		sphere.transform.position = new Vector3 (0, 0.5f, -3);
		Debug.Log("ffffffffffff");
	}
}
