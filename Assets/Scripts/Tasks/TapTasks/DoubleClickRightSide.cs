using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleClickRightSide : TapTask
{
    public override string Name { get; set; }
    public override event TaskComplete OnTaskComplete;

    public DoubleClickRightSide()
    {
        Name = "Double Click Right Side";
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
        return new IReward[] { new Money(10), new Limon(1), new Orange(2) };
    }
}
