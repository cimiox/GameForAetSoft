using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Control money cash
/// </summary>
public class Cash : MonoBehaviour 
{
	private static Text cashText;

	private static int count;
	public static int Count
	{
		get { return count;}
		set 
		{ 
			count = value;
			cashText.text = string.Format("Money: {0}", Count);
		}
	}
	
	private void Awake()
	{
		cashText = gameObject.GetComponent<Text>();
	}
}
