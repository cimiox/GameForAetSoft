using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleSwipeLeft : SwipeTask
{
    public override string Name { get; set; }
    public override event TaskComplete OnTaskComplete;

    public TripleSwipeLeft()
    {
        Name = "Triple Swipe Left";
        DirectionSwipe = DirectionSwipe.Left;
    }

    public override void Job()
    {
        CountSwipe++;
        if (CountSwipe >= 3)
        {
            base.DistributionAwards(GetReward());

            if (OnTaskComplete != null)
                OnTaskComplete(this);
        }
    }

    protected override IReward[] GetReward()
    {
        return new IReward[] { new Limon(2) };
    }
}
