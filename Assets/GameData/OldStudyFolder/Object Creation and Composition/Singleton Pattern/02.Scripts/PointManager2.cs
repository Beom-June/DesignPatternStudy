using UnityEngine;
using System.Collections;

public class PointManager2 : MonoBehaviour 
{
    int myPoint = 0;

    static PointManager2 _instance = null;
	public static PointManager2 Instance()
	{
		return _instance;
	}
	
	void Awake () 
	{
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            if (this != _instance)
            {
                Destroy(this.gameObject);
            }
        }

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
