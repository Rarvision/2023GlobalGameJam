using UnityEngine;

public class MopSet : FurnitureSet
{
    // ReSharper disable Unity.PerformanceAnalysis
    protected override void SetTrap()
    {
        gameManager.DebugInfo();
        gameManager.mop = true;
        hasUsed = true;
        StartMopEffect();
    }

    private void StartMopEffect()
    {
        Debug.Log("Mop effect started");
        Destroy(GameObject.Find("Water"));
    }
}
