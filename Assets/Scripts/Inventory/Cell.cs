using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class for cell
/// </summary>
public class Cell 
{
	public int ID { get; set; }
	public GameObject CellGO { get; set; }
	public IInventoryItem Reward { get; set; }	

	public Cell(int id, GameObject cellGO, IInventoryItem reward)
	{
		ID = id;
		CellGO = cellGO;
		Reward = reward;
	}
}
