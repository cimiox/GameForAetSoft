using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Base of type Task
/// </summary>
public abstract class Task 
{
	public delegate void TaskComplete(Task task);
	public abstract event TaskComplete OnTaskComplete;

	/// <summary>
	/// Name task
	/// </summary>
	public abstract string Name { get; set; }

	/// <summary>
	/// Work that needs to be done
	/// </summary>
	public abstract void Job();

	/// <summary>
	/// Rewards after work
	/// </summary>
	/// <returns>massif of rewards</returns>
	protected abstract IReward[] GetReward();

	/// <summary>
	/// Distribution all reward after complete task
	/// </summary>
	/// <param name="reward">massif of rewards </param>
	protected void DistributionAwards(IReward[] reward)
	{
		for (int i = 0; i < reward.Length; i++)
		{
			if (reward[i] is IInventoryItem)
				Inventory.Instance.AddItem(reward[i] as IInventoryItem);
			else
				Cash.Count += reward[i].Count;
		}
	}
}
