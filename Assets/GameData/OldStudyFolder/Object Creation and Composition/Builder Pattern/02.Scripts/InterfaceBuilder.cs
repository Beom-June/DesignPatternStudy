using UnityEngine;
using System.Collections.Generic;

// 'abstract Builder' class
interface IVehicleBuilder
{
    Vehicle getVehicle();

    void BuildFrame();
    void BuildEngine();
    void BuildWheels();
}

public enum VehicleType
{
    Car,
    MotorCycle
}

