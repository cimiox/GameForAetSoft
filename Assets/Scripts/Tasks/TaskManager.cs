using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// StartCoroutine in backend
/// </summary>
public class TaskManager : MonoBehaviour 
{
	public PoolTasks PoolTasks;

	void Awake () 
	{
		StartCoroutine(PoolTasks.GetTask());
	}
}
