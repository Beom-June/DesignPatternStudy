using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Race
{
    Terran,
    Protoss,
    Zerg
}

/// <summary>
/// The 'AbstractFactory' abstract class
/// </summary>
public abstract class RaceFactory : MonoBehaviour
{
    public abstract GameObject makeCapacityBuilding();
    public abstract GameObject makeUnitBuilding();
}
