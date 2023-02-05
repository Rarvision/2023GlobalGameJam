using UnityEngine;

public class PaintingHideElectricBoxSet : FurnitureSet
{
    // ReSharper disable Unity.PerformanceAnalysis
    protected override void SetTrap()
    {
        gameManager.DebugInfo();
        gameManager.electricityOn = false;
        
        hasUsed = true;
        SetElectricEffect();
    }

    private void SetElectricEffect()
    {
        var tvColl = GameObject.Find("TV+plug").GetComponent<BoxCollider2D>();
        tvColl.enabled = false;
        var fanBehaviour = GameObject.Find("Fan").GetComponent<FanBehaviour>();
        fanBehaviour.UpdateFanAnimation();
        var warnerBehaviour = GameObject.Find("Warner").GetComponent<WarnerBehaviour>();
        warnerBehaviour.UpdateWarnerAnimation();
    }
}