using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// One of type task
/// </summary>
public abstract class SwipeTask : Task 
{
	public int CountSwipe { get; set; }
	public DirectionSwipe DirectionSwipe { get; set; }
}
