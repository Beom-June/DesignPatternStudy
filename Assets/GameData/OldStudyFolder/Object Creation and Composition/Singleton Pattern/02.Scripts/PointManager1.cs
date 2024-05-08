using UnityEngine;
using System.Collections;

public class PointManager1 : MonoBehaviour 
{
    int myPoint = 0;

    static PointManager1 _instance = null;
	public static PointManager1 Instance()
	{
		return _instance;
	}
	
	void Awake () 
	{
        if (_instance == null)
            _instance = this;
    }

    public void AddPoint(int num)
	{
        myPoint = myPoint + num;
	}

    public int GetPoint()
    {
        return myPoint;
    }
}
