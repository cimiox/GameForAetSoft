using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// Swipe handler for task
/// </summary>
public class SwipeHandler : MonoBehaviour, IBeginDragHandler, IDragHandler
{
	public SwipeTask Task { get; set; }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if(Task != null)
        {
            if (Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y))
            {
                if (eventData.delta.x > 0 && Task.DirectionSwipe == DirectionSwipe.Right) 
                    Task.Job();
                else if (eventData.delta.x < 0 && Task.DirectionSwipe == DirectionSwipe.Left) 
                    Task.Job();
            }
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
    }
}
