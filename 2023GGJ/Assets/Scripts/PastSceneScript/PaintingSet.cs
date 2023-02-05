using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingSet : FurnitureSet
{
    // ReSharper disable Unity.PerformanceAnalysis
    protected override void SetTrap()
    {
        gameManager.painting = true;
        hasUsed = true;
        StartPaintingEffect();
    }

    private void StartPaintingEffect()
    {
        var electricBoxSet = GameObject.Find("ElectricSwitch_A").GetComponent<PaintingHideElectricBoxSet>();
        electricBoxSet.enabled = true;
        gameManager.painting = true;
        Destroy(gameObject);
    }
}
