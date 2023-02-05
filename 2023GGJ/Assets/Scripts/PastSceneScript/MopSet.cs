using UnityEngine;

public class MopSet : FurnitureSet
{
    // ReSharper disable Unity.PerformanceAnalysis
    protected override void SetTrap()
    {
        gameManager.mop = true;
        hasUsed = true;
        StartMopEffect();
    }

    private void StartMopEffect()
    {
        Destroy(GameObject.Find("Water_A"));
    }
}
