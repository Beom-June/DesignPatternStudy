using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAddPoint2 : MonoBehaviour {

    public int myNum = 0;

	void Start () {
        MyFunc();
    }

    void MyFunc()
    {
        PointManager2.Instance().AddPoint(myNum);
        int myResult = PointManager2.Instance().GetPoint();
        Debug.Log("Point : " + myResult);
    }

}
