using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour 
{
	public static Inventory Instance { get; set; }
	
	public GameObject Content;

	private const int inventroySize = 100;

	private static List<Cell> cells = new List<Cell>();
	public static List<Cell> Cells
	{
		get { return cells;}
		set { cells = value;}
	}

	private static GameObject cell;
	public static GameObject Cell
	{
		get 
		{ 
			if (cell == null)
				return cell = Resources.Load<GameObject>("Cell");
			return cell;
		}
	}
	
	private GameObject itemPrefab;
	public GameObject ItemPrefab
	{
		get 
		{ 
			if (itemPrefab == null)
				return itemPrefab = Resources.Load<GameObject>("Item");
			return itemPrefab;
		}
	}

	void Awake() 
	{
		if(Instance != null)
			Destroy(this);
		else 
			Instance = this;

		Initialize();
	}

	/// <summary>
	/// Intialize cells in inventory
	/// </summary>
	private void Initialize()
	{
		Cells = new List<Cell>();

		for (int i = 0; i < inventroySize; i++)
		{
			GameObject cell = Instantiate(Cell, Content.transform);
			cell.name = string.Format("Cell [{0}]", i);
			Cells.Add(new Cell(i, cell, null));
		}

		gameObject.SetActive(false);
	}

	/// <summary>
	/// Add item in inventory
	/// </summary>
	/// <param name="reward">inventory item</param>
	public void AddItem(IInventoryItem reward)
	{
		for (int i = 0; i < reward.Count; i++)
		{
			foreach (var item in Cells)
			{
				if (item.Reward == null)
				{
					item.Reward = reward;

					CreateItem(item.CellGO, item.Reward.Image);
					break;
				}
			}
		}
	}

	/// <summary>
	/// instantiate item in inventory
	/// </summary>
	/// <param name="parent">cell gameObject</param>
	/// <param name="sprite">image in inventory</param>
	private void CreateItem(GameObject parent, Sprite sprite)
	{
		GameObject item = Instantiate(ItemPrefab, parent.transform);
		item.name = "Item";
		item.GetComponent<Image>().sprite = sprite;
	}

	/// <summary>
	/// Method for inventory button(activate or deactivate inventroy window)
	/// </summary>
	public void SetActiveOrDeactiveInventory()
	{
		if (gameObject.activeSelf == false)
			gameObject.SetActive(true);
		else
			gameObject.SetActive(false);
	}
}
