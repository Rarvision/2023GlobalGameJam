using UnityEngine;

public class CigarBoxSet : FurnitureSet
{
    // ReSharper disable Unity.PerformanceAnalysis
    protected override void SetTrap()
    {
        gameManager.DebugInfo();
        gameManager.cigarBox = true;
        hasUsed = true;
        StartCigarBoxAnimation();
    }

    private void StartCigarBoxAnimation()
    {
        Debug.Log("Cigar box animation started");
    }
}
