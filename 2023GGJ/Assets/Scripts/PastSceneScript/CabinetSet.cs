using UnityEngine;

public class CabinetSet : FurnitureSet
{
    // ReSharper disable Unity.PerformanceAnalysis
    protected override void SetTrap()
    {
        gameManager.DebugInfo();
        gameManager.cabinet = true;
        hasUsed = true;
        StartCabinetBoxAnimation();
    }

    private void StartCabinetBoxAnimation()
    {
        Debug.Log("Cabinet animation started");
    }
}
