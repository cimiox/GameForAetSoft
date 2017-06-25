using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato : IInventoryItem
{
	private int count;
	public int Count 
	{ 
		set { count = value; }
		get { return count; }
	}

	private Sprite image;
	public Sprite Image 
	{ 
		set { image = value; }
		get { return image; }
	}

	public Tomato(int count)
	{
		Count = count;
		Image = Resources.Load<Sprite>("Sprites/Tomato");
	}

}
