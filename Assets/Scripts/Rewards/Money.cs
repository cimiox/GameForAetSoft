using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : IReward
{
    private int count;
	public int Count 
	{ 
		set { count = value; }
		get { return count; }
	}

	public Money(int count)
	{
		Count = count;
	}
}
