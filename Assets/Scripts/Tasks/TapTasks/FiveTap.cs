using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiveTap : TapTask
{
    public override string Name { get; set; }
    public override event TaskComplete OnTaskComplete;

    public FiveTap()
    {
        Name = "Five Tap";
    }

    public override void Job()
    {
        CountTap++;
        if (CountTap >= 5)
        {
            base.DistributionAwards(GetReward());
            OnTaskComplete(this);
        }
    }

    protected override IReward[] GetReward()
    {
        return new IReward[] { new Money(100), new Orange(1) };
    }
}
