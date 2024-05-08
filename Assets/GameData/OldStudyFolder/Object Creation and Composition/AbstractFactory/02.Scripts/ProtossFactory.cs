using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The 'ConcreteFactory2' class
/// </summary>
public class ProtossFactory : RaceFactory
{
    public GameObject pylon;
    public GameObject gateway;

    public override GameObject makeCapacityBuilding()
    {
        //return new Pylon();
        return Instantiate(pylon, new Vector3(-1.0f, 1.0f, 0.0f), Quaternion.identity);
    }

    public override GameObject makeUnitBuilding()
    {
        //return new Gateway();
        return Instantiate(gateway, new Vector3(1.0f, 0.5f, 0.0f), Quaternion.identity);
    }
}
