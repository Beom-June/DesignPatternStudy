using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyweightUse : MonoBehaviour {

	void Start () {
        UnitFactory factory = GetComponent<UnitFactory>();

        for (int i=0; i< 10; i++)
        {
            factory.getMarine("홍길동" + i);
        }

        GameObject p1 = factory.getMarine("홍길동");
        GameObject p2 = factory.getMarine("전우치");
        GameObject p3 = factory.getMarine("홍길동");

        if (p1 == p3)
        {
            Debug.Log("name : " + p1.GetComponent<Marine3>().getName());
        }
    }
}
