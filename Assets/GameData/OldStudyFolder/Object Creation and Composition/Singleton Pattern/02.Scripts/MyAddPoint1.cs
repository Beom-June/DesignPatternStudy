using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAddPoint1 : MonoBehaviour {

    public int myNum = 0;

	void Start () {
        MyFunc();
    }

    void MyFunc()
    {
        PointManager1.Instance().AddPoint(myNum);
        int myResult = PointManager1.Instance().GetPoint();
        Debug.Log("Point : " + myResult);
    }

}
