using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// For inventory item
/// </summary>
public interface IInventoryItem : IReward
{
	Sprite Image { get; set; }
}
