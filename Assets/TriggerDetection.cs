using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class TriggerDetection : Trigger
{
    protected override void Interaction1()
    {
        Debug.Log($"{name} is triggered");
    }

    protected override void Interaction2()
    {
        // do nothing
    }
}
