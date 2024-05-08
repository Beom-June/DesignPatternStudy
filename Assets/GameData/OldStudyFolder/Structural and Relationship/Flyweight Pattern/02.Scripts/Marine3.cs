using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marine3 : MonoBehaviour, Unit3
{
    public string name;
    public int hp;

    public void setName(string name)
    {
        this.name = name;
    }

    public string getName()
    {
        return name;
    }

    void Start()
    {

    }
}
