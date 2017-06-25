using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleClickButton : TapTask 
{
    public override string Name { get; set; }
    public override event TaskComplete OnTaskComplete;

    public DoubleClickButton()
    {
        Name = "Double Click Button";
    }

    public override void Job()
    {
        CountTap++;

        if (CountTap >= 2)
        {
            base.DistributionAwards(GetReward());
            OnTaskComplete(this);
        }
    }

    protected override IReward[] GetReward()
    {
        return new IReward[] { new Money(300) };
    }
}
