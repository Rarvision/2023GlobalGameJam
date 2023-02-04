using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanSet : FurnitureSet
{
    // ReSharper disable Unity.PerformanceAnalysis
    protected override void SetTrap()
    {
        gameManager.debugInfo();
    }
}