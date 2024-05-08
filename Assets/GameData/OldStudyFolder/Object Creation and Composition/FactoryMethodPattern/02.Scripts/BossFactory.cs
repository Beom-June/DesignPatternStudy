using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The 'Creator' abstract class
/// </summary>
abstract class BossFactory : MonoBehaviour
{
	// Factory Method
	public abstract void CreateBoss(Transform tran); 
}
