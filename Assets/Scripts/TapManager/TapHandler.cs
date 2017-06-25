using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// Tap handler for task
/// </summary>
public class TapHandler : MonoBehaviour, IPointerClickHandler
{
	public TapTask Task { get; set; }

    public void OnPointerClick(PointerEventData eventData)
    {
        Task.Job();
    }
}
