using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Concrete Observer
public class ConcreteObserver3 : Observer2
{
	float accTime = 0.0f;
	float limitTime = 0.0f;
	bool bRotate = false;

	public override void OnNotify(float time)
	{
		accTime = 0.0f;
		limitTime = time;
		bRotate = true;
	}

	void Update () {

		if ( accTime > limitTime ) {
			bRotate = false;
		}

		if ( bRotate ) {
			accTime += Time.deltaTime;

			transform.Rotate(100.0f * Time.deltaTime * Vector3.up);
		}
	}
}
