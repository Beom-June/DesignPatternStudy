using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour 
{
	float Speed = 10.0f;

	void Update () 
	{
		this.transform.Translate(Vector3.up * Speed * Time.deltaTime);
		
		if (this.transform.position.y > 10.0f)
		{
			Destroy(this.gameObject);
		}
	}
}
