using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleSwipeRight : SwipeTask
{
    public override string Name { get; set; }
    public override event TaskComplete OnTaskComplete;

    public TripleSwipeRight()
    {
        Name = "Triple Swipe Right";
        DirectionSwipe = DirectionSwipe.Right;
    }

    public override void Job()
    {
        CountSwipe++;
        if (CountSwipe >= 5)
        {
            base.DistributionAwards(GetReward());
            OnTaskComplete(this);
        }
    }

    protected override IReward[] GetReward()
    {
        return new IReward[] { new Tomato(5) };
    }
}
