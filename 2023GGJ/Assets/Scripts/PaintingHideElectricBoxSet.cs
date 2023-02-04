using UnityEngine;

public class PaintingHideElectricBoxSet : FurnitureSet
{
    // ReSharper disable Unity.PerformanceAnalysis
    protected override void SetTrap()
    {
        gameManager.DebugInfo();
        gameManager.paintingHideElectricBox = true;
        hasUsed = true;
        StartPaintingHideElectricBoxEffect();
    }

    private void StartPaintingHideElectricBoxEffect()
    {
        Debug.Log("Electric box effect started");
        var tvColl = GameObject.Find("TV+plug").GetComponent<BoxCollider2D>();
        if (tvColl != null)
        {
            Debug.Log("!!!");
        }

        tvColl.enabled = false;
    }
}